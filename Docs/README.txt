-------------------------------------------------------------------------------
                   EnIPExplorer- Ethernet/IP Explorer
-------------------------------------------------------------------------------

1.  INTRO

	1.1 ABOUT
		EnIPExplorer is a graphical windows program for exploring and navigating
		Ethernet/IP devices. 
		The project was created in order to test/teach/learn and evaluate the 
		protocol.		
	
		This document is subject to change.

	1.2 CREDITS
		The project was created by F. Chaxel, in 2016. 
		Graphics are the usual FamFamFam: http://www.famfamfam.com/
		It is, of course, inspired by the best Bacnet Explorer, Yabe :
		http://sourceforge.net/projects/yetanotherbacnetexplorer/
		and also Profinet Explorer
		http://sourceforge.net/projects/profinetexplorer/

2.  USAGE

	2.1 Exploration
		- Start EnIPExplorer
		- Select "Open Interface" under "Functions".
		- Press the "Add" button.
		  The program will now open an Udp connection and send out a
		  broadcast "ListIdentity". If Ethernet/IP devices exist on the local 
		  network they will show up in the tree.
		- If you have more than 1 ethernet card, you can also select the local 
		  ip interface (before you click the "Add"). Either select one from 
		  the list or write one by hand, if the interface is not displayed. 
		  The program will fetch all "Classes" from the devices and
		  display them in the tree. Nothing is displayed if the needed network 
		  service is not supported by the devices.
	2.2 Read Class data
		- When a device (Plc or other) is selected, the class list is requested
		  through the network and displayed (Read attribut n�1 -ObjectList- of 
		  the instance n�1 of the class n�2 -Message Router- ).
		- If a class is selected, a network request is sent and the class data
		  is read and displayed in the properties panel.
		- With the shortcut key CTRL-C one can add classes in the list to try
		  to read values (this will not add the class in the remote device,
		  it's just give you the possibility to read). 
		- F3 key will refresh the values.
	2.3 Read Class instances data
		- For common classes (Identity, MessageRouter, ...) one class instance
		  is already visible and could be read out. Select it and the values are 
		  displays in the properties panel.	
		- With the shortcut key CTRL-I one can add instances in the list to try
		  to read values (this will not add the instance in the remote device). 	
		- F3 key will refresh the values.	
	2.4 Attribut data (Read & Write)
		- With the shortcut key CTRL-A, same behaviour as �2.2 and $2.3
		- RawByte data could be modified at this level, and are sent to the 
		  remote device (change a value then hit Enter key).
		- F3 key will refresh the values.
	2.5 Advise : ForwardOpen T->O
		- On attributs one could place a ForwardOpen T->O (Device to EnIPExplorer).
		  If accepted, the Class 1 device (Plc or other) will send back 
		  the data by using Udp in point to point or multicast mode.
		  Nothing is done with the data, Wireshark could be used to see them, or
		  using the Class1 client sample.
	2.6 Configure: ForwardOpen O->T
		- Some job to do.
	2.7 Save/Open Files
		- The full Tree (from Devices to Attributs) could be save/load from
		  a file. This file could be edit/modify using an spreadsheet (Excel or
		  OpenOffice/LibreOffice for instance). The format isn't too complex
		  to be infers. It must be strictly respected.
		- The content Online & Offline (file) are merged together if some 
		  difference appears. The names coming from the file are the winners.
		- Several files could be open successively, the content are added.
		- Save is not automatic, but must be done by hand.

3.  SETTINGS OPTIONS
	3.1 TCP_LAN_Timeout & TCP_WAN_Timeout
		  - In ms : used for connection & read & write operations. LAN is for
		  autodiscovered devices, WAN for whoses added by the Menu Add manually.
		  - For the connection, the timeout is two time this value.
	3.2 PeriodicUpdateRate
		  - In ms : used to update the current selected Instance or property value
		    0 or less : option disabled. Min value is 200ms.
	3.3 DefaultRemoteDevice
		  - Used to fill the Textbox with this default value.
	3.4 CSVSeparator
		  - Value for treeview CSV file (spreadsheet compatible format) see �2.5.
	3.5 ForwardOpen
		  - Control parameters : requested cycle time (in ms) & duration (in sec.).
		    If the cycle is 0 ms, then a ChangeOfstate request is used.
			Duration is auto-adjusted in the range 1..60.

4.  TESTS
	The EnIPExplorer has been tested with really a too few number of others tools :
		- Wireshark.
		- Wago 750/881 	

5.  SUPPORT
	There's no support for the project at this time, and certainly never. 
	If you write to me, I'm unlikely to answer. 

6.  REPORT ERRORS
	Yes, there be errors alright. There always are. Many won't be interesting
	though. Eg. if you find a computer that behaves differently from others, 
	I'm unlikely to care. This is not a commercial project and I'm not trying 
	to push it to the greater good of the GPL world. (This may change though.)
	If you find a device that doesn't work with it, it might be interesting.
	But in order for me to fix it, I need either access to the physical device
	or printouts from programs like Wireshark, that displays the error.
	Write to me using the Sourceforge link.

7.  CONTRIBUTE
	Really? You think it's missing something? It's not really meant as a huge 
	project, but if you really must, try contacting me using the Sourceforge
	link.
	
8.  MISC
	Project web page is located at: 
	https://sourceforge.net/projects/EnIPExplorer/

9.  DEV. ROADMAP 
	Maybe decoding of standard classes.
	Maybe a rawdata user selectable format : byte, short, uhsort ...