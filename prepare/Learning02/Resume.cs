
    public class Resume
    {
        public string _name = "";
        public List<Job> _jobs = new List<Job>();


        // Constructor
        public Resume()
        {
        }

        public void Display()
        {
            // Name: Allison Rose
            // Jobs:
            // Software Engineer (Microsoft) 2019-2022
            // Manager (Apple) 2022-2023

            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Jobs: ");
            foreach (Job job in _jobs) {
                job.Display();
            }
        }
    }