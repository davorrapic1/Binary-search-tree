using System;
using System.Collections.Generic;

namespace binary
{
    class Node
    {
        private Node LeftNode;
        private Node RightNode;
        private int? _value;
  

        #region Recursive insert
        public void Insert(int value)
        {


            if(_value == null)
            {
                _value = value;
                return;
            } else if(value <= _value)
            {

                if (LeftNode == null)
                    LeftNode = new Node();
              
                LeftNode.Insert(value);
                return;
            }

            if (RightNode == null)
                    RightNode = new Node();
            RightNode.Insert(value);

        }

        #endregion
   
   
        #region Recursive search
        public void Search(int value)
        {
            if(_value == value)
            {
                Console.WriteLine("number found");
                return;
            } else if(value <= _value)
            {
                if(LeftNode == null)
                    return;

                LeftNode.Search(value);
            } 
             if(RightNode == null)
                    return;
            RightNode.Search(value);            
        }

        #endregion
    }
}
