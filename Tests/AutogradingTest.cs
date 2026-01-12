namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Assign_The_Prefix_Incremented_Value_Of_Visitors_To_A_Class_Level_Variable_Named_PrefixIncrement(){
        var counter = new Counter();
        Assert.Equal(101, counter.PrefixIncrement);
    }

    [Fact]
    public void Should_Assign_The_Postfix_Incremented_Value_Of_Visitors_To_A_Class_Level_Variable_Named_PostfixIncrement(){
        var counter = new Counter();
        Assert.Equal(101, counter.PostfixIncrement);
    }[Fact]
    public void Should_Assign_The_Prefix_Decremented_Value_Of_Visitors_To_A_Class_Level_Variable_Named_PrefixDecrement(){
        var counter = new Counter();
        Assert.Equal(101, counter.PrefixDecrement);
    }

    [Fact]
    public void Should_Assign_The_Postfix_Decremented_Value_Of_Visitors_To_A_Class_Level_Variable_Named_PostfixDecrement(){
        var counter = new Counter();
        Assert.Equal(101, counter.PostfixDecrement);
    }

    [Fact]
    public void Should_Have_A_Final_Value_Of_100_Stored_In_The_Variable_Visitors(){
        var counter = new Counter();
        Assert.Equal(100, Counter.Visitors);
    }
}