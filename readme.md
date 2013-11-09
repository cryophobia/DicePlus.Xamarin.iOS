DICE+ SDK for Xamarin.iOS
=============================

This Xamarin.iOS project binds `DicePlus.framework v. 2.2.1` library.

## Prerequisites

In order to compile the `DicePlus.Xamarin.iOS.dll` you need to obtain and include `DicePlus.a` file.

Steps to obtain and include `DicePlus.a`:

1. Go to [http://www.developers.dicepl.us/](http://www.developers.dicepl.us/).
2. Register an Account or log in using your credentials.
3. Navigate to [http://www.developers.dicepl.us/show/download](http://www.developers.dicepl.us/show/download)
4. Download and unzip the iOS SDK - **DicePlus.framework v. 2.2.1**
5. Copy `DicePlus` from `DicePlus.framework/Versions/Current/` to temporary folder and rename to `DicePlus.a`.

## Building DicePlus.Xamarin.iOS.dll

In order to build `DicePlus.Xamarin.iOS.dll`:

**Via Xamarin Studio**

1. Open Xamarin Studio
2. Click on **File > Open…** and locate `/Path/to/DicePlus.Bindings.Xamarin/DicePlus.Bindings.Xamarin.sln`
3. Right click on **DicePlus.Bindings.Xamarin.iOS** Project in the Solution window, select **Add > Add Files**. Find the `DicePlus.a` static library and copy it into the solution.
3. Build the project.
4. You will find `DicePlus.Xamarin.iOS.dll` inside `/Path/to/DicePlus.Bindings.Xamarin/DicePlus.Bindings.Xamarin.iOS/bin` folder

## Testing and Code Example

Once you have successfully compiled the `DicePlus.Xamarin.iOS.dll`, include it in the `/Path/to/DicePlus.Bindings.Xamarin/DicePlus.Bindings.Xamarin.sln` lib folder. Attach your iPad and watch the Application output window to see your DICE+ connect, and get each DICE+ roll.

## License

Copyright (c) 2013 The Other Brother

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

## Disclaimer

DICE+ is a trademark of Game Technologies S.A. All rights reserved.

Mono is a registered trademark and MonoTouch, Mono Tools, MonoDevelop and Moonlight are trademarks of Novell, Inc. in the United States and other countries.

Other trademarks and trade names are those of their respective owners.

## Authors

Chris van Wyk
