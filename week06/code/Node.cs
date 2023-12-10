public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value == Data)
        {
            //duplicate found
            return;
        }

        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        bool valueFound = false;
        if (value == Data)
        {
            valueFound = true;
            return valueFound;
        }

        if (value < Data)
        {
            // Search to the left
            if (Left != null)
            {
                bool exist = Left.Contains(value);
                if( exist == true)
                {
                    valueFound = true;
                }

            }
               
        }
        else
        {
            // Search to the right
            if (Right != null)
            {
                bool exist = Right.Contains(value);
                if (exist == true)
                {
                    valueFound = true;
                }
            }
               
                
        }
        return valueFound;
    }

    public int GetHeight() {
        int hightLeft = 0;
        int hightRight = 0;
        if (Left != null)
        {
            hightLeft = Left.GetHeight();

        }

        if (Right != null)
        {
            hightRight = Right.GetHeight();
        }
        // 1 represets the actual node
        return 1 + Math.Max(hightLeft, hightRight);
    }
}