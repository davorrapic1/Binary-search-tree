namespace binary
{
    class Tree 
    {
        private Node rootNode;

        public Tree()
        {
            rootNode = new Node();
        }

     public void Insert(int num)
     {
         rootNode.Insert(num);
     }

     public void Search(int value)
     {
         rootNode.Search(value);
     }

        public void OrderTree(Tree tree)
        {
            tree.rootNode.Order(tree.rootNode);
        }

    }


}
