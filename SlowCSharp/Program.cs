//
// Program.cs
//
// Author:
//       Stephen Shaw <shaw@xamarin.com>
//
// Copyright (c) 2015 Xamarin Inc. (http://xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.Collections;

namespace SlowCSharp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!\n\n");
			DoStuff ();
		}

		static void DoStuff ()
		{
			ArrayList listOfAbundantNumbers = new ArrayList ();
			ArrayList listOfSums = new ArrayList ();
			long total = 0;

//			for (int i = 1; i < 20162; i++) {
//			for (int i = 1; i < 10081; i++) {
			for (int i = 1; i < 5000; i++) {
					listOfAbundantNumbers.Add (i);
				total += i;
			}

			for (int i = 1; i < listOfAbundantNumbers.Count; i++)
			{
				for (int a = 0; a < listOfAbundantNumbers.Count; a++)
				{
					long temp1 = Convert.ToInt64 (listOfAbundantNumbers [i]);
					long temp2 = Convert.ToInt64 (listOfAbundantNumbers [a]);
					long num = temp1 + temp2;

					if (listOfSums.Contains (num))
						listOfSums.Add (num);
				}
			}

			for (int i = 1; i < listOfAbundantNumbers.Count; i++)
			{
				long temp1 = Convert.ToInt64 (listOfAbundantNumbers [i]);
				total -= temp1;
			}

			Console.WriteLine (total + "");
		}

	}
}
