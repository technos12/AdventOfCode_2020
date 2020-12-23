using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rawRules = Data.GetRules();
            List<string> Messages = Data.GetMessages();

            Dictionary<int, string> Rules = new Dictionary<int, string>();


            rawRules.Clear();
            rawRules.Add("0: 4 1 5");
            rawRules.Add("1: 2 3 | 3 2");
            rawRules.Add("2: 4 4 | 5 5");
            rawRules.Add("3: 4 5 | 5 4");
            rawRules.Add("4: a");
            rawRules.Add("5: b");

            //Convert rules into a Dictionary for simpler usage.
            foreach (string rule in rawRules)
            {
                int index = int.Parse(rule.Substring(0, rule.IndexOf(':')));
                string thisRule = rule.Substring(rule.IndexOf(':') + 2);

                Rules.Add(index, thisRule);
            }

            //While Rule 0 is not completed
            while(!isRuleOnlyLetters(Rules[0]))
            {
                //Find a rule which contains only a b or |
                KeyValuePair<int, string> ruleToApply = new KeyValuePair<int, string>();
                foreach (KeyValuePair<int, string> rule in Rules)
                {
                    ruleToApply = new KeyValuePair<int, string>();

                    string ruleValueWithoutSpace = rule.Value.Replace(" ", "");
                    if (Regex.IsMatch(ruleValueWithoutSpace, @"^[a-z|]+$"))
                    {
                        ruleToApply = rule;
                        break;
                    }
                }

                //Replace all rules with this data
                if (ruleToApply.Key != 0)
                {
                    var rulesToReplace = Rules.Where(p => p.Value.Contains(ruleToApply.Key.ToString())).ToArray();

                    foreach (var item in rulesToReplace)
                    {
                        Rules[item.Key] = Rules[item.Key].Replace(ruleToApply.Key.ToString(), ruleToApply.Value.ToString());
                    }
                    Rules.Remove(ruleToApply.Key);
                }
            }
            
        }

        static bool isRuleOnlyLetters(string rule)
        {
            string ruleChars = rule.Replace(" ", "");
            ruleChars = ruleChars.Replace("|","");

            return ruleChars.All(Char.IsLetter);
        }
    }
}
