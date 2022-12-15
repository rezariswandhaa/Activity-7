using System;

namespace CircularQueues_CSharp
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int elemen)
        {
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                if (REAR == max - 1)
                    REAR = 0;
                else
                    REAR = REAR + 1;
            }
            queue_array[REAR] = elemen;
        }

        public void remove()
        {
            if (FRONT == - 1)
            {
                Console.WriteLine("Queue underflow\n");
                return ;

            }
            Console.WriteLine("\nThe element deleted from the queue is: " + queue_array[FRONT] + "\n");

            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                    FRONT = REAR + 1;
            }
        }

        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;

            if (FRONT == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElement in the queue are..........\n");
            if (FRONT_position <= REAR_position)
            {
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                while (FRONT_position <= max - 1)
                {
                    Console.Write(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }
                FRONT_position = 0;

                while(FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }

    }
}