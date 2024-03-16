using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball_HW
{
    internal class Model : IModel
    {
        public string GetAnswer()
        {
            string[] answers = { "Звісно так.", "Моя відповідь – \"ні\".", 
                                 "Мені здається, що так.", "Не можу зараз вам сказати.", 
                                 "Не зрозуміло, спробуйте ще раз.", "Ні, навіть не думай.", 
                                 "Зосередься та спитай знову.", "Скоріш за все.",
                                 "Жодних сумнівів.", "Є добрі перспективи.",
                                 "Дуже малоймовірно.", "Безумовно." };
            Random random = new Random();
            int i = random.Next(answers.Length);
            return answers[i];
        }
    }
}