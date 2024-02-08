

namespace practice_2_4
{
    class Robot
    {
        private string Name;
        private int x;
        private int y;
        private int Direction;
        public const int North = 0;
        public const int East = 1;
        public const int South = 2;
        public const int West = 3;
        public const int Left = 4;
        public const int Right = 5;
        public const int World_size = 10;
        private Random random = new Random((int)DateTime.Now.Ticks);
        public void Intialize(string Name, int x, int y,int Direction)
        {
            this.Name = Name;
            this.x = x;
            this.y = y;
            this.Direction = Direction;
        }
        public void Print()
        {
            Console.WriteLine("name of the robot:{0}",this.Name);
            Console.WriteLine("x co-ordinate of robot:{0}",this.x);
            Console.WriteLine("y co-ordinate of robot:{0}", this.y);
            Console.WriteLine("direction of robot:{0}",Conv_Direction(this.Direction));
        }
        public void Step()
        {
            int r = random.Next(2);
            if(r == 0)
            {
                Console.WriteLine("Move");
                Move();
            }
            else if(r == 1)
            {
                int p = random.Next(2);
                if (p == 0)
                {
                    Console.WriteLine("left");
                    Turn(Left);
                }
                else if (p == 1)
                {
                    Console.WriteLine("right");
                    Turn(Right);
                }
            }
        }
        public void Move()
        {
            if (this.Direction == North)
                this.y = (this.y + World_size) % World_size;
            else if (this.Direction == East)
                this.x = (this.x + World_size) % World_size;
            else if (this.Direction == South)
                this.y = (this.y - World_size) % World_size;
            else if (this.Direction == West)
                this.x = (this.x - World_size) % World_size;
        }
        public void At(int goalx,int goaly)
        {
            int count = 0;
            while(this.x!=goalx || this.y!=goaly)
            {
                Console.WriteLine("x:{0};y:{1}",this.x,this.y);
                Step();
                count++;
            }
            Console.WriteLine(count);
        }
        public void Turn(int to)
        {

            if (to == Left)
            {
                if (this.Direction == North)
                    this.Direction = West;
                else if (this.Direction == East)
                    this.Direction = North;
                else if (this.Direction == West)
                    this.Direction = South;
                else if (this.Direction == South)
                    this.Direction = East;
            }
            else if (to == Right)
            {
                if (this.Direction == North)
                    this.Direction = East;
                else if (this.Direction == East)
                    this.Direction = South;
                else if (this.Direction == West)
                    this.Direction = North;
                else if (this.Direction == South)
                    this.Direction = West;
            }
        }

        public string Conv_Direction(int d)
        {
            switch (d)
            {
                case 0:
                    return "North";
                case 1:
                    return "East";
                case 2:
                    return "South";
                case 3:
                    return "west";
                case 4:
                    return "Left";
                case 5:
                    return "Right";
                default:
                    return "Error";
            }
        }
    }
}
