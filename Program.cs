// See https://aka.ms/new-console-template for more information
/*
-   Main.js   -

function main() {
  const guests = getGuests();
  const tables = {
    "Table 1": [],
    "Table 2": []
  };

  for (const guest of guests) {
    const table1Occupations = tables["Table 1"].map(g => g.occupation);
    if (table1Occupations.includes(guest.occupation)) {
      tables["Table 2"].push(guest);
    } else {
      tables["Table 1"].push(guest);
    }
  }
  
  for (const tableName of Object.keys(tables)) {
    const tableGuests = tables[tableName]; 
    console.log(tableName);
    for (const guest of tableGuests) {
      console.log(`${guest.name} (${guest.occupation}) ${guest.bio}`);
    }
  }
}


function getGuests() {
  return [
    {
      name: "Marilyn Monroe",
      occupation: "entertainer",
      bio: "(1926 - 1962) American actress, singer, model"
    },
    {
      name: "Abraham Lincoln",
      occupation: "politician",
      bio: "(1809 - 1865) US President during American civil war"
    },
    {
      name: "Martin Luther King",
      occupation: "activist",
      bio: "(1929 - 1968)  American civil rights campaigner"
    },
    {
      name: "Rosa Parks",
      occupation: "activist",
      bio: "(1913 - 2005)  American civil rights activist"
    },
    {
      name: "Peter Sellers",
      occupation: "entertainer",
      bio: "(1925 - 1980) British actor and comedian"
    },
    {
      name: "Alan Turing",
      occupation: "computer scientist",
      bio: "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
    },
    {
      name: "Admiral Grace Hopper",
      occupation: "computer scientist",
      bio: "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
    },
    {
      name: "Indira Gandhi",
      occupation: "politician",
      bio: "(1917 - 1984) Prime Minister of India 1966 - 1977",
    }
  ];
}

main();


*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Guest
{
    public string Name { get; set; }
    public string Occupation { get; set; }
    public string Bio { get; set; }

    public Guest(string name, string occupation, string bio)
    {
        Name = name;
        Occupation = occupation;
        Bio = bio;
    }
}
public class Program
{
    public static void Main()
    {
        List<Guest> guests = GetGuests();
        Dictionary<string, List<Guest>> tables = new Dictionary<string, List<Guest>>()
        {
            {"Table 1", new List<Guest>()},
            {"Table 2", new List<Guest>()}
        };

        foreach (Guest guest in guests)
        {
            List<string> table1Occupations = tables["Table 1"].Select(g => g.Occupation).ToList();
            if (table1Occupations.Contains(guest.Occupation))
            {
                tables["Table 2"].Add(guest);
            }
            else
            {
                tables["Table 1"].Add(guest);
            }
        }

        foreach (var table in tables)
        {
            Console.WriteLine(table.Key);
            foreach (Guest guest in table.Value)
            {
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
            }
        }
    }

    public static List<Guest> GetGuests()
    {
        return new List<Guest>
        {
            new Guest("Marilyn Monroe", "entertainer", "(1926 - 1962) American actress, singer, model"),
            new Guest("Abraham Lincoln", "politician", "(1809 - 1865) US President during American civil war"),
            new Guest("Martin Luther King", "activist", "(1929 - 1968) American civil rights campaigner"),
            new Guest("Rosa Parks", "activist", "(1913 - 2005) American civil rights activist"),
            new Guest("Peter Sellers", "entertainer", "(1925 - 1980) British actor and comedian"),
            new Guest("Alan Turing", "computer scientist", "(1912 - 1954) British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"),
            new Guest("Admiral Grace Hopper", "computer scientist", "(1906–1992) developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"),
            new Guest("Indira Gandhi", "politician", "(1917 - 1984) Prime Minister of India 1966 - 1977")
        };
    }
}