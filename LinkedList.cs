namespace data_structures
{


    public class Queue
    {
        public int Value;
        public Queue next = null;
        public int getValue() { return Value; }
        public Queue getnext() { return next; }
        public void setValue(int value) { Value = value; }
        public void setnext() { next = null; }



        public Queue(int data)
        {
            Value = data;
        }


    }


    public class LinkedList
    {

        Queue head;
        public LinkedList()
        {

        }

        public LinkedList(int data)
        {
            head.Value = data;
        }

        //O(n)
        // Method to add to  the end of the list
        public void Add(int data)
        {
            Queue newNode = new Queue(data);
            if(head == null)
            {
                head = newNode;
                return;
            }
            Queue temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }

        //O(n)
        public string Display()
        {
            string print = "";
            Queue temp = head;
            while(temp != null)
            {
                //Console.Write(temp.Value + " -> ");
                print += temp.Value;
                temp = temp.next;
                if(temp != null)
                { print += " -> "; }
            }
            return print;
        }

        //O(n)
        public int Length()
        {
            int sum = 0;
            Queue temp = head;
            while(temp != null)
            {
                sum++;
                temp = temp.next;
            }
            return sum;
        }

        //O(1)
        // Method to remove the first value
        public void RemoveValue(int data)
        {
            if(head == null)
                return;
            if(head.Value == data)
            {
                head = head.next;
                return;
            }
            Queue temp = head;
            while(temp.next != null)
            {
                if(temp.next.Value == data)
                {
                    temp.next = temp.next.next;
                    return;
                }
                temp = temp.next;

            }
        }
        //O(1)
        // Method to remove the value in an index
        public void RemoveIndex(int data)
        {
            if(head == null)
            {
                return;
            }
            var tamp = head;
            for(int i = 0; i < data - 1; i++)
            {
                tamp = tamp!.next;
            }
            if(tamp!.next!.next == null)
            {
                tamp!.next = null;
                return;
            }
            tamp.next = tamp.next!.next;
            tamp = null;

        }

        //O(1)
        // Method to remove all the  value
        public void RemoveAllValues(int data)
        {
            head = null;
        }


        //O(n)
        // Method to find by value
        public int Find(int data)
        {
            int index = 0;
            Queue temp = head;
            while(temp != null)
            {
                if(temp.Value == data)
                {
                    return index;
                }
                temp = temp.next;
                index++;
            }
            return -1;
        }

        //O(1)
        // Method to get a value by  index and return the value
        public int Get(int data)
        {
            Queue temp = head;
            for(int i = 0; temp != null && i <= data;)
            {
                if(i == data)
                {
                    return temp.Value;
                }
                i++;
                temp = temp.next;
            }
            return -1;
        }
    }

}
