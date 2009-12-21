BDDish.NET
==========

BDDish.NET is a set of thin wrappers around the NUnit and xUnit testing frameworks that allows you
to write assertions in a BDD-ish kind of way. I created it for two reasons. First, as an experiment
to try and use as few interfaces as possible just to see how far generics and linq would allow me to go.
Second is that I can never remember on which side actual and expected stuff should be :)

There are a few "doubtful" assertions on the xUnit side and by doubtful I mean that I used Assert.True
with lambda expressions instead of extending xUnit with custom assertions. They do however give you
straight forward error messages.

Installation
------------

Coming soon. If you want to take it out for a spin right now => open solution, compile, add references to your project

Examples
--------

### Boolean

    Expect.That( 1 == 1 ).Is.True();
    Expect.That( 1 == 1 ).Is.Not.False();
    Expect.That( 1 == 1 ).Should.Be.True();
    Expect.That( 1 == 1 ).Should.Not.Be.False();
    Expect.That( 1 == 1 ).Must.Be.True();
    Expect.That( 1 == 1 ).Must.Not.Be.False();

    Expect.That( 1 == 0 ).Is.False();
    Expect.That( 1 == 0 ).Is.Not.True();
    Expect.That( 1 == 0 ).Must.Be.False();
    Expect.That( 1 == 0 ).Must.Not.Be.True();
    Expect.That( 1 == 0 ).Should.Be.False();
    Expect.That( 1 == 0 ).Should.Not.Be.True();

### IComparable

    Expect.That( 1 + 1 ).Must.Be.Equal.To( 2 );
    Expect.That( 1 + 1 ).Is.NotEqual.To( 1 );
    Expect.That( 1 + 1 ).Must.Be.Greater.Than( 1 );
    Expect.That( 1 + 1 ).Should.Be.Greater.Than( 1 );
    Expect.That( 1 + 1 ).Is.Greater.Than( 1 );
    Expect.That( 1 + 1 ).Is.GreaterOrEqual.To( 2 );
    Expect.That( 1 + 1 ).Must.Be.Less.Than( 3 );
    Expect.That( 1 + 1 ).Should.Be.Less.Than( 3 );
    Expect.That( 1 + 1 ).Should.Be.LessOrEqual.To( 2 );
    Expect.That( 1 + 1 ).Must.Be.LessOrEqual.To( 2 );

### Reference

    var a = new object();
    var b = new object();

    Expect.That( a ).Should.Not.Be.Null();
    Expect.That( a ).Must.Not.Be.Null();
    Expect.That( a ).Is.Not.Null();

    Expect.That( a ).Should.Be.Same.As( a );
    Expect.That( a ).Should.Not.Be.Same.As( b );
    Expect.That( a ).And( a ).Are.Same();
    Expect.That( a ).And( a ).Are.The.Same();
    Expect.That( a ).And( b ).Are.Not.The.Same();
    Expect.That( a ).And( b ).Are.Not.Same();
    Expect.That( a ).And( b ).Is.Not.The.Same();
    Expect.That( a ).And( a ).Is.The.Same();
    Expect.That( a ).And( b ).Is.Not.Same();

    b = null;

    Expect.That( b ).Is.Null();
    Expect.That( b ).Must.Be.Null();
    Expect.That( b ).Should.Be.Null();

### String

    Expect.That( "abc" ).Is.Equal.To( "abc" );
    Expect.That( "abc" ).Equals( "abc" );
    Expect.That( "abc" ).Is.Not.Equal.To( "aac" );
    Expect.That( string.Empty ).Is.Empty();
    Expect.That( "abc" ).Is.Not.Empty();
    Expect.That( "abc" ).Must.Not.Be.Empty();
    Expect.That( "abc" ).Should.Not.Be.Empty();
    Expect.That( string.Empty ).Should.Be.Empty();
    Expect.That( string.Empty ).Must.Be.Empty();
    Expect.That( "abc" ).Starts.With( "a" );
    Expect.That( "abc" ).Does.Start.With( "a" );
    Expect.That( "abc" ).Does.Not.Start.With( "c" );
    Expect.That( "abc" ).Ends.With( "c" );
    Expect.That( "abc" ).Does.End.With( "c" );
    Expect.That( "abc" ).Does.Not.End.With( "a" );
    Expect.That( "abc" ).Does.Not.Contain( "d" );
    Expect.That( "abc" ).Does.Contain( "a" );
    Expect.That( "abc" ).Contains( "b" );
    Expect.That( "abc" ).Matches( "abc" );

    string test = null;
    Expect.That( test ).Is.Null();
    Expect.That( "test" ).Is.Not.Null();
    Expect.That( "test" ).And( "test" ).Are.The.Same();
    Expect.That( "test" ).And( "hey" ).Are.Not.The.Same();

### IEnumerable<T>

    var list = new List<int>();
    list.Add( 1 );

    Expect.That( list ).Contains( 1 );
    Expect.That( list ).Does.Contain( 1 );
    Expect.That( list ).Must.Contain( 1 );
    Expect.That( list ).Should.Contain( 1 );

    Expect.That( list ).Does.Not.Contain( 2 );
    Expect.That( list ).Must.Not.Contain( 2 );
    Expect.That( list ).Should.Not.Contain( 2 );

    Expect.That( list ).Is.Not.Empty();
    Expect.That( list ).Must.Not.Be.Empty();
    Expect.That( list ).Should.Not.Be.Empty();

    var empty = new List<string>();

    Expect.That( empty ).Is.Empty();
    Expect.That( empty ).Must.Be.Empty();
    Expect.That( empty ).Should.Be.Empty();

    Expect.That( empty ).And( empty ).Are.The.Same();
    Expect.That( empty ).And( new List<string>() ).Are.Not.The.Same();

    Expect.That( empty ).Is.Not.Null();

    empty = null;

    Expect.That( empty ).Is.Null();

### IEnumerable

    var list = new ArrayList();
    Expect.That( list ).Is.Empty();
    Expect.That( list ).Is.Not.Null();
    Expect.That( list ).Does.Not.Contain( 1 );

    list.Add( 1 );
    Expect.That( list ).Is.Not.Empty();
    Expect.That( list ).Should.Contain( 1 );
    Expect.That( list ).Does.Not.Contain( "bogus" );

License
-------

The MIT License
 
Copyright (c) 2009 Ilia Mikhailov
 
Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:
 
The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.
 
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

