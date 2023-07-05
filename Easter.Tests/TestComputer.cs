using EasterApi;

namespace Easter.Tests;

public class TestComputer
{
    [Theory]
    [InlineData(1982, 04, 11)]
    [InlineData(2000, 04, 23)]
    [InlineData(2001, 04, 15)]
    [InlineData(2002, 03, 31)]
    [InlineData(2003, 04, 20)]
    [InlineData(2004, 04, 11)]
    [InlineData(2005, 03, 27)]
    [InlineData(2006, 04, 16)]
    [InlineData(2007, 04, 08)]
    [InlineData(2008, 03, 23)]
    [InlineData(2009, 04, 12)]
    [InlineData(2010, 04, 04)]
    [InlineData(2011, 04, 24)]
    [InlineData(2012, 04, 08)]
    [InlineData(2013, 03, 31)]
    [InlineData(2014, 04, 20)]
    [InlineData(2015, 04, 05)]
    [InlineData(2016, 03, 27)]
    [InlineData(2017, 04, 16)]
    [InlineData(2018, 04, 01)]
    public void TestComputeEaster(int year, int month, int day)
    {
        Assert.Equal(new DateTime(year, month, day), Computer.ComputeEaster(year));
    }
}  