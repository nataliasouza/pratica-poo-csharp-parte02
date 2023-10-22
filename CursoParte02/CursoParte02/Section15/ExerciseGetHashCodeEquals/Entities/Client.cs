
namespace CursoParte02.Section15.ExerciseGetHashCodeEquals.Entities
{
    internal class Client
    {
        public string Name { get; set; }    
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is  Client client))
            {
                return false;
            }

            Client otherClient = obj as Client;
            return Email.Equals(otherClient.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
