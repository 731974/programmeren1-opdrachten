namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            program.Start();

        }
        void Start()
        {

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            string response = IsValidPassword(password);

            Console.WriteLine(response);
        }

        string IsValidPassword(string password)
        {

            int length = password.Length;
            string response;
            bool hasUpperCaseCharacter = false;
            bool hasNumber = false;

            if (length < 8)
            {
                response = "Password is not valid, it should be at least 8 characters long.";
            }
            else
            {
                response = "Password is valid.";

                for (int i = 0; i < length; i++)
                {

                    if (char.IsUpper(password[i]) || hasUpperCaseCharacter == true)
                    {
                        hasUpperCaseCharacter = true;

                    } 

                    if (char.IsNumber(password[i]) || hasNumber == true)
                    {
                        hasNumber = true;
                    }
                }

                if(!hasNumber)
                {
                    response = "Password invalid. It must contain a number!";
                }
                if(!hasUpperCaseCharacter)
                {
                    response = "Password invalid. It must contain at least one uppercase character";
                }

            }

            return response;
        }
    }
}
