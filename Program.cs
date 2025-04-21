//begin main
using System.ComponentModel;
using System.Net.WebSockets;
using codingchallenge;

// string firstMenuChoice = GetFirstMenuChoice();
// AsciiArt asciiArt = new AsciiArt(); // Create an instance of AsciiArt      
//  if (firstMenuChoice == "1")
// {
//     string name = BeginStory(asciiArt);
//     ContinueYourStory(asciiArt);
//     PadawanMasterMatching();
    
// }
//  else
// {
//     System.Console.WriteLine("Thank you for playing!");
//             // Exit the loop
// }



// //end main




// static string GetFirstMenuChoice(){
//     System.Console.WriteLine("Welcome to Star Wars : Make Your Own Way!");
//     Console.ReadKey(); // Wait for user to press a key
//         string input = Console.ReadLine() ?? ""; // Handle potential null input
    
//     return input;
// }

// static string BeginStory(AsciiArt asciiArt){
//     System.Console.WriteLine("A long time ago in a galaxy far, far away...");
//     System.Console.WriteLine("Welcome to the Star Wars Galaxy! First, let's get to know you a little better. What is your name?");
//     string name = Console.ReadLine() ?? ""; // Handle potential null input
//     System.Console.WriteLine($"Hello, {name}!");
//     asciiArt.DisplayJediCharacter();
//     return name; // Return the name to satisfy the method's return type
// }
// static void ContinueYourStory(AsciiArt asciiArt){
//     System.Console.WriteLine("Now that you have your name, let's continue your story!");
//     System.Console.WriteLine("You have arrived at the Jedi Temple on Coruscant where you are greeted by Master Yoda");
//     asciiArt.DisplayYoda();
//     System.Console.WriteLine("Master Yoda: \"Welcome, young Jedi. Your training begins now.\"");
//     //System.Console.WriteLine("You have a choice to make: \n1. Train in the ways of the Force \n2. Go on a mission to save the galaxy");
// } 

// static string PadawanMasterMatching(){
//     int score = 0;
//     System.Console.WriteLine("The time has come for you to become a Padawan. To determine who will be your master, you must answer a series of questions.");
//     System.Console.WriteLine("Question 1: How do you approach a mission with uncertain outcomes? \n1. I trust my instincts and embrace the unkown \n2. I follow my intuition and adapt as needed \n3. I assess the emotional impact and collaborate with others \n4. I carefully plan and consider all risks beifre proceeding \n5. I rely on my strength and willpower to overcome challenges");
//     string answer1 = Console.ReadLine() ?? ""; 
//     if(answer1 == "1"){
//         score += 1;
//     } else if(answer1 == "2"){
//         score += 2;
//     } else if(answer1 == "3"){
//         score += 3;
//     } else if(answer1 == "4"){
//         score += 4;
//     } else if(answer1 == "5"){
//         score += 5;
//     } else {
//         System.Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
//     }
//     System.Console.WriteLine("Question 2: What is your view on the Jedi Code \n1. It's a guideline, not a strict rule, and sometimes it’s meant to be broken. \n2. It's a foundation, but personal judgment and intuition play a key role.  \n3. It’s a balance between tradition and compassion.  \n4. It’s a sacred code that must be upheld.  \n5. The Jedi Code must be followed strictly, no exceptions. ");
//     string answer2 = Console.ReadLine() ?? "";
//     if(answer2 == "1"){
//         score += 1;
//     } else if(answer2 == "2"){
//         score += 2;
//     } else if(answer2 == "3"){
//         score += 3;
//     } else if(answer2 == "4"){
//         score += 4;
//     } else if(answer2 == "5"){
//         score += 5;
//     } else {
//         System.Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
//     }
//     System.Console.WriteLine("Question 3: How do you handle failure? \n1. I learn from it quickly and move on, trusting the Force to guide me.  \n2. I seek understanding, adjust my approach, and move forward with clarity.  \n3. I discuss it with others to learn and grow from the experience.  \n4. I accept responsibility, analyze my actions, and strive to improve.  \n5. I reflect deeply on it and use it to strengthen my resolve.");
//     string answer3 = Console.ReadLine() ?? "";
//     if(answer3 == "1"){
//         score += 1;
//     } else if(answer3 == "2"){
//         score += 2;
//     } else if(answer3 == "3"){
//         score += 3;
//     } else if(answer3 == "4"){
//         score += 4;
//     } else if(answer3 == "5"){
//         score += 5;
//     } else {
//         System.Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
//     }
//     System.Console.WriteLine("Question 4: What is your leadership style? \n1. I lead by challenging the status quo and inspiring others to think differently.  \n2. I lead with wisdom, trusting the Force, and guiding others toward their potential.  \n3. I lead with compassion, valuing emotional connection and teamwork.  \n4. I lead with balance and fairness, ensuring everyone’s voice is heard.  \n5. I lead with authority, decisiveness, and by showing strength.");
//     string answer4 = Console.ReadLine() ?? "";
//     if(answer4 == "1"){
//         score += 1;
//     } else if(answer4 == "2"){
//         score += 2;
//     } else if(answer4 == "3"){
//         score += 3;
//     } else if(answer4 == "4"){
//         score += 4;
//     } else if(answer4 == "5"){
//         score += 5;
//     } else {
//         System.Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
//     }
//     System.Console.WriteLine("Question 5: How do you view emotions in regard to decision making? \n1. Emotions are a powerful guide, and I don’t shy away from them.  \n2. Emotions should be balanced with reason and intuition in decision-making.  \n3. Emotions help me understand others and guide my decisions.  \n4. Emotions must be controlled and not cloud judgment.  \n5. Emotions must be suppressed to maintain clarity and control.");
//     string answer5 = Console.ReadLine() ?? "";
//     if(answer5 == "1"){
//         score += 1;
//     } else if(answer5 == "2"){
//         score += 2;
//     } else if(answer5 == "3"){
//         score += 3;
//     } else if(answer5 == "4"){
//         score += 4;
//     } else if(answer5 == "5"){
//         score += 5;
//     } else {
//         System.Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
//     }
//     System.Console.WriteLine("Question 6:What is your stance on questioning authority?  \n1. Questioning authority is essential, and I challenge it when necessary.  \n2. Authority should be questioned when it goes against the greater good or the Force.  \n3. Authority must be respected, but I believe in respectful dialogue and collaboration.  \n4. Authority is important, but it should only be challenged if absolutely necessary.  \n5. Authority must be respected and followed without question.");
//     string answer6 = Console.ReadLine() ?? "";
//     if(answer6 == "1"){
//         score += 1;
//     } else if(answer6 == "2"){
//         score += 2;
//     } else if(answer6 == "3"){
//         score += 3;
//     } else if(answer6 == "4"){
//         score += 4;
//     } else if(answer6 == "5"){
//         score += 5;
//     } else {
//         System.Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
//     }
//     System.Console.WriteLine("Question 7:How do you handle conflict?  \n1. I confront it head-on, often with unconventional methods.  \n2. I seek peaceful resolutions through understanding and diplomacy.  \n3. I focus on finding a compassionate, fair outcome that benefits everyone.  \n4. I strive for balance, aiming for just and fair resolutions.  \n5. I handle it with strength, authority, and a focus on control.");
//     string answer7 = Console.ReadLine() ?? "";
//     if(answer7 == "1"){
//         score += 1;
//     } else if(answer7 == "2"){
//         score += 2;
//     } else if(answer7 == "3"){
//         score += 3;
//     } else if(answer7 == "4"){
//         score += 4;
//     } else if(answer7 == "5"){
//         score += 5;
//     } else {
//         System.Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
//     }
//     System.Console.WriteLine("Question 8:What is your approach to training others?  \n1. I encourage independence and unconventional methods.  \n2. I focus on intuition and personal growth, trusting the Force in each student.  \n3. I promote emotional intelligence and foster strong connections with my students.  \n4. I ensure a structured, balanced approach, guiding my students with care and wisdom.  \n5. I emphasize discipline, control, and unwavering focus.");
//     string answer8 = Console.ReadLine() ?? "";
//     if(answer8 == "1"){
//         score += 1;
//     } else if(answer8 == "2"){
//         score += 2;
//     } else if(answer8 == "3"){
//         score += 3;
//     } else if(answer8 == "4"){
//         score += 4;
//     } else if(answer8 == "5"){
//         score += 5;
//     } else {
//         System.Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
//     }
//     System.Console.WriteLine("Question 9:What do you think the role of the Jedi is in the galaxy? \n1. We should act freely, not constrained by rules or bureaucracy.  \n2. We should guide others with wisdom and compassion, not bound by dogma.  \n3. We should serve others with empathy and understanding, focusing on peace.  \n4. We must uphold peace and justice with balance, following the Jedi Code.  \n5. We must maintain order and control, upholding the strictest code.");
//     string answer9 = Console.ReadLine() ?? "";
//     if(answer9 == "1"){
//         score += 1;
//     } else if(answer9 == "2"){
//         score += 2;
//     } else if(answer9 == "3"){
//         score += 3;
//     } else if(answer9 == "4"){
//         score += 4;
//     } else if(answer9 == "5"){
//         score += 5;
//     } else {
//         System.Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
//     }
//     System.Console.WriteLine("Final Question! ");
//     System.Console.WriteLine("Question 10: What is your greatest strength?  \n1. My ability to adapt and think outside the box, even when it’s risky.  \n2. My deep connection to the Force and my intuitive understanding of its will.  \n3. My empathy and ability to connect with others on an emotional level.  \n4. My wisdom and ability to maintain balance and perspective in any situation.  \n5. My strength, discipline, and unwavering resolve in the face of adversity.");
//     string answer10 = Console.ReadLine() ?? "";
//     if(answer10 == "1"){
//         score += 1;
//     } else if(answer10 == "2"){
//         score += 2;
//     } else if(answer10 == "3"){
//         score += 3;
//     } else if(answer10 == "4"){
//         score += 4;
//     } else if(answer10 == "5"){
//         score += 5;
//     } else {
//         System.Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
//     }
//     System.Console.WriteLine("The time has come to reveal your Jedi Master!...");
//     if(score <=18){
//         Thread.Sleep(2000);
//         System.Console.WriteLine("Your master is Quinlan Voss! He is known for his unorthodox methods and ability to adapt to any situation. He will teach you to trust your instincts and embrace the unknown.");
//         string master = "Quinlan Voss";
//         return master;
//     } else if(score>18 && score <=26){
//         Thread.Sleep(2000);
//         System.Console.WriteLine("Your master is Qui Gon Jinn! He is known for his wisdom and deep connection to the Force. He will guide you to trust your intuition and understand the will of the Force.");
//         string master = "Qui Gon Jinn";
//         return master;
//     } else if(score >26 && score<=34){
//         Thread.Sleep(2000);
//         System.Console.WriteLine("Your master is Aayla Secura! She is known for her compassion and ability to connect with others. She will teach you the importance of empathy and understanding in your journey as a Jedi.");
//         string master = "Aayla Secura";
//         return master;
//     } else if(score >34 && score <=42){
//         Thread.Sleep(2000);
//         System.Console.WriteLine("Your master is Obi Wan Kenobi! He is known for his wisdom and ability to maintain balance. He will guide you to find harmony in your training and in the galaxy.");
//         string master = "Obi Wan Kenobi";
//         return master;
//     } else if(score >42){
//         Thread.Sleep(2000);
//         System.Console.WriteLine("Your master is Mace Windu! He is known for his strength and discipline. He will teach you the importance of control and focus in your training as a Jedi.");
//         string master = "Mace Windu";
//         return master;
//     } else {
//         System.Console.WriteLine("Invalid input.");
//         return "Unknown Master"; // Ensure a return value in this case
//     }

// }