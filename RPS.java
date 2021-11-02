
public class RPS {
	public static String gameRPS(char player1, char player2)
	{
	     
	  
	    if (player1 == player2)
	        return "TIE" ;
	   
	    if (player1 == 'R')
	    {
	        if (player2 == 'S')
	            return "Player 1 wins";
	        else
	            return "Player 2 wins";
	    }
	    if (player1 == 'P')
	    {
	        if (player2 == 'R')
	            return "Player 1 wins";
	        else
	            return "Player 2 wins";
	    }
	    if (player1 == 'S')
	    {
	        if (player2 == 'P')
	            return "Player 1 wins";
	        else
	            return "Player 2 wins";
	    }
	     
	    return "TIE";
	}
	static boolean isVowel(char c) {
	    return (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' ||
	            c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
	}
	 
	public static void main(String[] args) {
		//show case the game rock, paper, scissors
		System.out.println(gameRPS('S', 'P')); 
		

		//show case Pig Latin
		String str = "amazing young people";
	        String[] arrOfStr = str.split(" ");
	 
	        for (String a : arrOfStr) {
	        	Character c=a.charAt(0);
	        	if (isVowel(c)) {
	        		System.out.print(a+"WAY" +" ");
	        	}
	        	else {
	        		System.out.print(a.substring(1)+c+"ay"+ " ");}
	        	}
	    
	}

}
