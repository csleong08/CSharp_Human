namespace Human
{
    public class Human 
    {
        public string hName;
        public int hStrength;
        public int hIntelligence;
        public int hDexterity;
        public int hHealth; 

        public Human(string name) 
        {
            hName = name;
            hStrength = 3;
            hIntelligence = 3;
            hDexterity = 3;
            hHealth = 100;
        }

        public Human(string name, int str, int intel, int dex, int hp) 
        {
            hName = name;
            hStrength = str;
            hIntelligence = intel;
            hDexterity = dex;
            hHealth = hp;
        }

        public void Attack(object obj)
        {
            Human enemy = obj as Human; 
            if (enemy == null)
            {
                System.Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.hHealth -= 5 * hStrength;
            }
            
        }
    }
}