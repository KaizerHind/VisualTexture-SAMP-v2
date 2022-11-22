## 💾 - VisualTexture v2
VisualTexture is a Multi-tool which i created a couple of years ago, which has the purpose of displaying some information about sa-mp, basically it is a kind of Wiki in Software version.

This tool allows you to `generate hexcolor's`, `view samp textures`, `animations`, `sprites` and later possibly a couple of other things. The animations section has an instance which is connected to the web platform to view these animations, since for the moment the idea is to try to reproduce animations within the software itself, but so far it is just an idea.

![enter image description here](https://media.discordapp.net/attachments/559900721252925458/848858048557744158/unknown.png)
___
	- Related projects:
[![- Source Code Old](https://i.imgur.com/KZYyFtk.png)](https://github.com/KaizerHind/VisualTexture_Pawn_SA-MP)  
[
![Extension Web](https://i.imgur.com/Abel0Hl.png)
](https://github.com/KaizerHind/PreviewAnims)
- **Note: Is important download in your NuGet Packages inside of VisualStudio the following elements ['cef.redist.x64, cef.redist.x86, CefSharp.Common y CefSharp.CWinForms'](https://www.mediafire.com/file/w64043xcnqmar42/packages.rar/file) and install the reference 'Bunifu' that is compressed in the project, u have the option of downloading these plugins and installing them yourself or installing them manually through VisualStudio.**
## Installation
	1.- Clone the repo in your folder preferred:
	$git clone https://github.com/KaizerHind/VisualTexture-SAMP-v2
	
	2.- Download e install the NuGet Packages. (cef.redist, CefSharp.Common,
	CefSharp.CWinForms)
	
	3.- Open the .sln file in VisualStudio, and in case the reference 'Bunifu'
	presents a warning, just right click on it and 'remove', then right click
	on 'References' and 'Add reference'.
	
	4.- Press the 'Browse' button and it will look for the
	'Bunifu_UI_v1.5.3.dll' file, select it and proceed to press 'OK'.
	
	Once all this is done, you can run VisualTexture without any problem.

# Updates:
# `Version 1.2.1` l # Changes released: 21 - Nov - 2022 
- [x]  *The files were fixed, because they could not be loaded in **Visual Studio** correctly.*
##
# `Version 1.2.1` l # Changes released: 18 - Feb - 2022 
 - [x]  *Fixed a bug which did not allow displaying texture information for each option in the **Listbox**.*
 - [x] *New textures added. **(This is being done in every small update constantly)***
 - [ ] Work is underway on an alternative option made in **OpenGL** to replace the Inline Animation Viewer with one built into the software.
 - [ ] Somen't very ethical features will be superseded over time.
##
# `Version 1.2.1` l # Changes released: 07 - June - 2021
- [x]  *The VSprites tool was added. (By Lorenc_)*
- [x]  *A new method to display animations was successfully configured. (Cef + WebPage + Three.js)*
- [x]  *Some text boxes and other data were changed and added.*
- [x]  *Now when you click on a Texture, it will show its PawnInfo. (Before it showed the information when clicking on RadioButtons, therefore that option was replaced)*
##
# `Version 1.2.1` l # Changes released: 30 - May - 2021

- [x]  *The way to choose and view the information of the textures was modified.*
- [x]  *A couple of corrections were made and it is planned to change the way to view the animations. (The method used will be the same as that used in Version 1).*
- [x]  *Resource content was added. (1,5%)*
- [x]  The ColorPicker tool created by **[Zume](https://github.com/Zume-Zero)** was added.
- [x]  Made UI fixes related to the up and down tool.
##
# `Version 1.2.0` l # Changes released: 05 - April - 2021 

- [x]  *The code and the software interface were rebuilt.*
- [x] *Some unnecessary parts of the code have been removed.*
##
# `Version 1.2` l # Changes released: 04 - July - 2020

- [x]  *Animations and textures section were added. (They arent fully ready yet)*
- [x]  *Added a custom way to view animations using [Clara.io](http://clara.io/).*
- [x]  *Currently only the ped.ifp library was added in Animations.*
- [x]  *Adjustments were made in the [Bunifu](https://bunifuframework.com/) interface.*
##
# `Version 1.0` l # Changes released: 17 - May - 2020

- [x]  *Now you can move the panel by selecting any region of the form.*
- [x]  *The way to access the forms(tools) has been optimized, now you have the option to enter the VisualTexture sections more easily.*
- [x]  *The code has been optimized a little more.*
