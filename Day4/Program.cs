using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Data.GetData();
            List<string> passports = new List<string>();

            //int passportIndex = 0;
            string passportData = "";

            foreach (string line in data)
            {
                if (line == "")
                {
                    passports.Add(passportData.TrimEnd());
                    passportData = "";
                    //passportIndex++;
                    continue;
                }
                else
                {
                    passportData += line + " ";
                }
            }

            if (passportData != "")
                passports.Add(passportData.TrimEnd());

            int nbPassportValid = 0;

            //Fields
            //byr(Birth Year)
            //iyr(Issue Year)
            //eyr(Expiration Year)
            //hgt(Height)
            //hcl(Hair Color)
            //ecl(Eye Color)
            //pid(Passport ID)
            //cid(Country ID)


            foreach (string passport in passports)
            {
                if (passport.Contains("byr") &&
                    passport.Contains("iyr") &&
                    passport.Contains("eyr") &&
                    passport.Contains("hgt") &&
                    passport.Contains("hcl") &&
                    passport.Contains("ecl") &&
                    passport.Contains("pid") /*&&
                    passport.Contains("cid")*/)
                {

                    string[] parts = passport.Split(' ');

                    Dictionary<string, string> fields = new Dictionary<string, string>();
                    foreach (string part in parts)
                    {
                        string[] subparts = part.Split(':');

                        string key = subparts[0];
                        string value = subparts[1];

                        fields.Add(key, value);
                    }

                    //byr validation
                    if (fields["byr"].Length == 4)
                    {
                        int byr = int.Parse(fields["byr"]);
                        if (byr >= 1920 && byr <= 2002)
                        {
                            //iyr validation
                            if (fields["iyr"].Length == 4)
                            {
                                int iyr = int.Parse(fields["iyr"]);
                                if (iyr >= 2010 && iyr <= 2020)
                                {
                                    //eyr validation
                                    if (fields["eyr"].Length == 4)
                                    {
                                        int eyr = int.Parse(fields["eyr"]);
                                        if (eyr >= 2020 && eyr <= 2030)
                                        {
                                            //hgt validation
                                            bool hgtValid = false;
                                            int hgt = 0;
                                            if (fields["hgt"].EndsWith("cm"))
                                            {
                                                hgt = int.Parse(fields["hgt"].Substring(0, fields["hgt"].Length - 2));
                                                if (hgt >= 150 && hgt <= 193)
                                                    hgtValid = true;
                                            }
                                            else if (fields["hgt"].EndsWith("in"))
                                            {
                                                hgt = int.Parse(fields["hgt"].Substring(0, fields["hgt"].Length - 2));
                                                if (hgt >= 59 && hgt <= 76)
                                                    hgtValid = true;
                                            }

                                            if (hgtValid)
                                            {
                                                //hcl validation
                                                if (fields["hcl"][0] == '#')
                                                {
                                                    string hcl = fields["hcl"].Substring(1);
                                                    if (hcl.Length == 6)
                                                    {

                                                        Regex r = new Regex("^[a-f0-9]*$");
                                                        if (r.IsMatch(hcl))
                                                        {

                                                            //ecl validation
                                                            string ecl = fields["ecl"];
                                                            if (ecl == "amb" ||
                                                                ecl == "blu" ||
                                                                ecl == "brn" ||
                                                                ecl == "gry" ||
                                                                ecl == "grn" ||
                                                                ecl == "hzl" ||
                                                                ecl == "oth" )
                                                            {

                                                                //pid validation
                                                                string pid = fields["pid"];
                                                                if (pid.Length == 9)
                                                                {
                                                                    int pidVal = int.Parse(pid);

                                                                    nbPassportValid++;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("nb valid passports : " + nbPassportValid);

        }
    }
}
