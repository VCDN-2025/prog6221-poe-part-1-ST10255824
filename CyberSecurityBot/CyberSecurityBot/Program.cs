
using System.Media;

namespace CyberSecurityBot
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayVoiceGreeting();
            DisplayAsciiArt();
            StartChat();
        }
        //https://stackoverflow.com/questions/3502311/how-to-play-a-sound-in-c-net
        static void PlayVoiceGreeting()
        {
            try
            {
                //displays greeting sound signaling the login of a user in the application
                using (SoundPlayer player = new SoundPlayer("greeting.wav"))
                {
                    player.PlaySync();
                }
            }
            catch
            {
                //diplays a error message if the sound greeting.wav file is not found or if error has occured 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("🔇 Voice greeting could not be played. Make sure 'greeting.wav' is in the correct place and make sure it is under the correct name");
                Console.ResetColor();
            }
        }
        //displays the cyber security logo in ascii in cyan blue
        static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
     ___________________________
    |  _______________________  |
    | |                       | |
    | |   CYBERSECURITY BOT   | |
    | |_______________________| |
    |___________________________|
        || ||     ||     || ||
        || ||     ||     || ||
        || ||     ||     || ||
        || ||     ||     || ||
        || ||     ||     || ||
       [__||_____||_____||__]
       |_____________________|

    🔒  SECURITY MODE ACTIVATED 🔒
==================================================
");
            Console.ResetColor();
        }

        // beggining of application where user is asked for their name 
        //https://www.w3schools.com/cs/cs_user_input.php
        static void StartChat()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\n🤖 Hello there! What's your name? ");
            Console.ResetColor();
            string userName = Console.ReadLine();
            Console.WriteLine();

            //users name is captured and used through out the application showing user engagement 
            //https://www.w3schools.com/cs/cs_conditions.php
            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "Cyber Cadet";
            }
            // short introducution statement explaining the purpose of the application
            TypingEffect($"🖖 Welcome, {userName}! I'm here to help you stay cyber-safe. Ask me anything cybersecurity-related, or type 'help' to see what I know!");

            //https://www.w3schools.com/cs/cs_while_loop.php
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"\n🟢 {userName}: ");
                Console.ResetColor();
                string input = Console.ReadLine().ToLower();

                //if statement to display that there was no question asked
                //https://www.w3schools.com/cs/cs_conditions.php
                if (string.IsNullOrWhiteSpace(input))
                {
                    TypingEffect("😅 That was... nothing. Try typing something!");
                }
                //else if statements displaying if user asked that specific question and porvides a answer for each question asked
                else if (input.Contains("how are you"))
                {
                    TypingEffect("🤖 I'm feeling encrypted and enthusiastic!");
                }
                else if (input.Contains("purpose"))
                {
                    TypingEffect("🔍 I'm here to help you stay safe in the digital jungle.");
                }
                else if (input.Contains("password"))
                {
                    TypingEffect("🔑 Bot Tip: Use a long password with a mix of letters, numbers, symbols – and *never* your pet’s name!");
                }
                else if (input.Contains("phishing"))
                {
                    TypingEffect("🎣 Bot Tip: If that email feels fishy, don’t click the link. It’s probably bait.");
                }
                else if (input.Contains("antivirus"))
                {
                    TypingEffect("🛡️ Bot Tip: Antivirus software is like garlic to digital vampires. Keep it updated!");
                }
                else if (input.Contains("public wifi"))
                {
                    TypingEffect("📶 Bot Tip: Public Wi-Fi is free — so is the risk. Use a VPN and avoid banking in coffee shops.");
                }
                else if (input.Contains("vpn"))
                {
                    TypingEffect("🔒 Bot Tip: VPN = Virtual Private Ninja. Be invisible online.");
                }
                else if (input.Contains("2fa") || input.Contains("two factor") || input.Contains("authentication"))
                {
                    TypingEffect("📲 Bot Tip: 2FA is like a secret handshake for your apps. Always enable it!");
                }
                else if (input.Contains("social media"))
                {
                    TypingEffect("📸 Bot Tip: Don’t overshare. Your vacation photos can wait — so burglars don’t get ideas.");
                }
                else if (input.Contains("email scam") || input.Contains("scam email"))
                {
                    TypingEffect("📬 Bot Tip: If it sounds too good to be true, it's probably a scam. Ignore and report!");
                }
                else if (input.Contains("update"))
                {
                    TypingEffect("🔄 Bot Tip: Updates patch security holes. Postpone them, and hackers might RSVP.");
                }
                else if (input.Contains("cookies"))
                {
                    TypingEffect("🍪 Bot Tip: Not the tasty kind. These cookies track your behavior. Accept wisely!");
                }
                // adds a help option which allows the user to view the different questions that can be asked
                else if (input == "help")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n========================= 📚 ASK ME ABOUT 📚 =========================");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(" 🤔  how are you         – Feeling curious?");
                    Console.WriteLine(" 🎯  what's your purpose – Learn my job.");
                    Console.WriteLine(" 🔑  passwords           – Tips for secure passwords.");
                    Console.WriteLine(" 🎣  phishing            – Spot fake emails & scams.");
                    Console.WriteLine(" 🛡️  antivirus           – Keep the baddies away.");
                    Console.WriteLine(" 📶  public wifi         – Risky biz in coffee shops.");
                    Console.WriteLine(" 🕵️‍♂️  vpn                – Ninja-mode activated.");
                    Console.WriteLine(" 📲  2FA / authentication – Double lock your accounts.");
                    Console.WriteLine(" 📸  social media        – Think before you post.");
                    Console.WriteLine(" 📬  scam emails         – Recognize & avoid them.");
                    Console.WriteLine(" 🔄  software updates    – No more 'remind me later'.");
                    Console.WriteLine(" 🍪  cookies             – They're watching.");
                    Console.WriteLine(" 🚪  exit / quit / bye   – End the convo.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("=====================================================================\n");
                }
                // displays options for the user to close the application
                else if (input == "exit" || input == "quit" || input == "bye")
                {
                    //displays message that indiactes the appication is being closed
                    TypingEffect("👋 Stay safe out there, " + userName + "! Logging off...");
                    break;
                }
                else
                {
                    //diplays message to show that the message the user has enetred is invalid 
                    TypingEffect("🤷 I didn’t quite catch that. Type 'help' to see what I can help with.");
                }
            }
        }
        // adds a delay for the bots response
        //https://krutarthpurohit.medium.com/different-ways-to-provide-time-delays-in-c-program-df4cc849b19b
        static void TypingEffect(string message, int delay = 30)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
