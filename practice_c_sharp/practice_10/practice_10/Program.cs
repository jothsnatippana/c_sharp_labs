using practice_10;

class Driver
{
    static void Main(string[] args)
    {
        Employee[] e1 = new Employee[5];
        e1[0] = new Manager("manju",4589.56,"manju_secretary");
        e1[1] = new Programmer("manju1", 3456.8, 567.8);
        e1[2] = new Intern("manju2", 234.6, 12);
        e1[3] = new Manager("manju3", 4587.56, "manju4_secretary");
        e1[4] = new Programmer("manju4", 3458.8, 6567.8);

        for(int i=0;i<5;i++)
        {
            if (e1[i] is Manager)
            {
                Manager m1 = (Manager)e1[i];
                m1.Print();
                IGoodStudent gs = m1;
                gs.Promote();
            }
            else if (e1[i] is Programmer)
            {
                Programmer p1 = (Programmer)e1[i];
                p1.Print();
                p1.Promote();
            }
            else if (e1[i] is Intern)
            {
                Intern intern = (Intern)e1[i];
                intern.Print();
            }
        }
    }
}