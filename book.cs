Create a C# program to manage a photo book using object-oriented programming.

To start, create a class called PhotoBook with a private attribute numPages of type int. 
It must also have a public method GetNumberPages that will return the number of photo book pages.

The default constructor will create an album with 16 pages. 
There will be an additional constructor, with which we can specify the number of pages we want in the album.

There is also a BigPhotoBook class whose constructor will create an album with 64 pages.

Finally create a PhotoBookTest class to perform the following actions:

Create a default photo book and show the number of pages
Create a photo book with 24 pages and show the number of pages
Create a large photo book and show the number of pages



using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class PhotoBook
    {
        protected int numPage;
        public int GetNumberPages()
        {
            return numPage;
        }
        public PhotoBook()
        {
            numPage = 16;
        }
        public PhotoBook(int page)
        {
            numPage = page;
        }
    }
    class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook()
        {
            numPage = 64;
        }
    }
    class PhotoBookTest 
    {
        public static void Main()
        {
            PhotoBook book1 = new PhotoBook();
            Console.WriteLine("No. of pages : "+book1.GetNumberPages());
            PhotoBook book2 = new PhotoBook(24);
            Console.WriteLine("No. of pages : " + book2.GetNumberPages());
            BigPhotoBook book3 = new BigPhotoBook();
            Console.WriteLine("No. of pages : " + book3.GetNumberPages());
            Console.ReadLine();
        }
       
    }
}