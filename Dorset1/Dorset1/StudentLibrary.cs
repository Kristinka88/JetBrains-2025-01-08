using System.Security.Cryptography.X509Certificates;

namespace Dorset1 
{
    public class Student  // Define the Student class
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Score { get; set; }
                public bool hasPassed { get; set; }
                
                public override string ToString()
                {
                    return $"Name: {Name}, {Subject} : {Score} : {hasPassed}";
                }
            
        }
    }
