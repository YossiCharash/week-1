namespace data_structures
{
    public class LinkList
    {

        public class Node
        {
            public int Value;
            public Node next = null;
            public int getValue() { return Value; }
            public Node getnext() { return next; }
            public void setValue(int value) { Value = value; }
            public void setnext() { next = null; }



            public Node(int data)
            {
                Value = data;
            }


        }


        public class LinkedList
        {
            Node head;

            public LinkedList()
            {

            }

            public LinkedList(int data)
            {
                head.Value = data;
            }

            // Method to add to  the end of the list
            public void Add(int data)
            {
                Node newnode = new Node(data);
                if(head == null)
                {
                    head = newnode;
                    return;
                }
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                    if(temp.next == null)
                    {
                        temp.next = new Node(data);
                    }
                }
            }


            public void Display()
            {
                Node temp = head;
                if(temp.Value == null)
                { Console.WriteLine(""); }
                while(temp.next != null)
                {
                    Console.Write(temp.next.Value + " ");
                    temp = temp.next;
                }
            }

            public int Length()
            {
                int sum = 0;
                Node temp = head;
                while(temp.next != null)
                {
                    sum++;
                    temp = temp.next;
                }
                return sum;
            }

            // Method to remove the first value
            public void RemoveValue(int data)
            {
                Node temp = head.next;
                head = temp;

            }

            // Method to remove the first value
            public void RemoveAllValues(int data)
            {
                head = null;
            }

            // Method to remove the value in an index
            //public void RemoveIndex(int data)
            //{
            //    int index = data;
            //    Node temp = head;
            //    while(temp.next != null)
            //    {
            //        if(index == data)
            //        {
                        
            //        }
            //        temp = temp.next;
            //        index++;
            //    }
                
            //}

            // Method to find by value
            public int Find(int data)
            {
                int index = -1;
                Node temp = head;
                while(temp.next != null)
                {
                    if(temp.Value == data)
                    {
                        return index;
                    }
                    temp = temp.next;
                    index++;
                }
                return index;
            }

            // Method to get a value by  index
            public int Get(int data)
            {
                Node temp = head;
                while(temp.next != null)
                {
                    if(data == 0)
                    {
                        return temp.Value;
                    }
                    temp = temp.next;
                }
                return -1;
            }
        }
    }
}
