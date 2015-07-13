#### wfdbMatDL
A simple data downloader for Physionet ECG data base. (no waveform preview)

===
##### What is "Physionet"?
[Physionet](http://www.physionet.org/) is a free research source offering lots of physiological signal records.

===
Physionet is a great data source for researching. But I believe that most people can not be used to using the 
[PhysioToolkit] provided by it in first time.

Although it is a powerful toolkit, most people may just want to get data in a more convenient way. So that another
two web interfaces([LightWAVE], [PhysioBank ATM]) were provided on Physionet.

But I think that we can have a faster and more convenient way to access the database, so I wrote this.

This is not a complicated job to access PhysioBank. I just analyze URL of each data and use regular expression 
to handle it.

Currently, this program works well. But it is not efficient enough. For each time we switch to another database, 
it has to take time to re-analyze and refresh. I will try to use another way to handle the information of database.

And there is an unsolved problem. Once a data haven't be called from web interface for a period of time(I'm not 
sure about it, maybe one month), we can not download it by this program directly. If you run into this problem,
you can just copy the URL inside the message box and paste it on internet explorer to get that file.

I will fix these bugs up if I have time, sorry about it.

But still hope this helps :)

[Physionet]: http://www.physionet.org/
[PhysioToolkit]: http://www.physionet.org/physiotools/wfdb-windows-quick-start.shtml
[LightWave]: http://www.physionet.org/lightwave/
[PhysioBank ATM]: http://www.physionet.org/cgi-bin/atm/ATM
