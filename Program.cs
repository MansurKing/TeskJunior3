using System;

namespace TaskJunior3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameUser;
            string genderUser; 
            string zodiacSign; 
            string workUser;
            int ageUser;

            Console.WriteLine("Приветствую очаровательный человек, который все таки решил пройти мой социальный опрос о таком наилучшем и великим человеком как вы =)))\nИтак начнем:");
            Console.Write("Как тебя звать 'ООО ВЕЛИКИЙ ЧЕЛОВЕК': ");
            nameUser = Console.ReadLine();
            
            Console.Write("Сколько столетий ты прожил 'ООО ВЕЛИКИЙ ЧЕЛОВЕК': ");
            ageUser = Convert.ToInt32(Console.ReadLine());            
           
            Console.Write("К какому богу ты приклоняешься из ЗНАКОВ ЗАДИАКА 'ООО ВЕЛИКИЙ ЧЕЛОВЕК': ");
            zodiacSign = Console.ReadLine();
            
            Console.Write("Каким ремеслом ты занимаешься в реальном МИРЕ 'ООО ВЕЛИКИЙ ЧЕЛОВЕК': ");
            workUser = Console.ReadLine();

            Console.WriteLine($"ООО ВЕЛИКИЙ {nameUser}, которому {ageUser} столетий, который прислуживает богу {zodiacSign} и '{workUser}' ремесло которое приносит данному " +
                              $"Господину каждый день не только удовольствие, но и горы золота и женщин!!!");

        }
    }
}
