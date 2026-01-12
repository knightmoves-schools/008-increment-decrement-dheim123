namespace knightmoves;

public class Counter
{
    public static int Visitors = 100;

    // Class-level variables to store the results
    public static int PrefixIncrement;
    public static int PostfixIncrement;
    public static int PrefixDecrement;
    public static int PostfixDecrement;

    static Counter()
    {
        // To result in a final value of 100, we execute the operations in sequence:
        
        // 1. Prefix Increment: Visitors becomes 101, PrefixIncrement gets 101
        PrefixIncrement = ++Visitors;

        // 2. Postfix Increment: PostfixIncrement gets 101, Visitors becomes 102
        PostfixIncrement = Visitors++;

        // 3. Prefix Decrement: Visitors becomes 101, PrefixDecrement gets 101
        PrefixDecrement = --Visitors;

        // 4. Postfix Decrement: PostfixDecrement gets 101, Visitors becomes 100
        PostfixDecrement = Visitors--;
    }
}
