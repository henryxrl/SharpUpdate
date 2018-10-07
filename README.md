
# SharpUpdate
SharpUpdate is written in C#. It reads a xml file on the server that contains update information such as version, MD5, and update log, download the update, close the current app, and open the updated app in 5 seconds.

[Note 1] This is used and further improved in the project SimpeEpub2. The improved version supports DotNetBar UI framework, multilingual UI, high DPI etc. If interested, please check out SimpleEpub2 by visiting https://github.com/henryxrl/SimpleEpub2

[Note 2] To create the xml file automatically (i.e, a UI for user-input update log, update date filled automatically, MD5 checked automatically etc), please check out "GenereateUpdateXML" project, which is a sub project under "SimpleEpub2".

# Update History

### Update 2018-10-07
 - Support for updating multiple files
 - Support three types of update jobs:
   1. **Update**: replace the older version local file by the newer version from the server
   2. **Add**: download a file from the server
   3. **Remove**: remove a local file

# How to use?

### WinForms
 
 For example, in a simple WinForms class, simply add:

```C#
public partial class Form1 : Form
{
    private SharpUpdater updater;

    public Form1()
    {
        InitializeComponent();

        updater = new SharpUpdater(Assembly.GetExecutingAssembly(), this, new Uri("update-xml-location"));
    }

    private void button1_Click(object sender, EventArgs e)
    {
        updater.DoUpdate();
    }
}
```

### XML

For details on the xml on the server with update information, please check out the sample "project.xml". A basic structure is as following:

```xml
<?xml version="1.0"?> 
<sharpUpdate> 
    <update> 
        <version></version> 
        <url></url> 
        <filePath></filePath>
        <md5></md5>
        <description></description> 
        <launchArgs></launchArgs> 
    </update>
    
    <add> 
        <version></version> 
        <url></url> 
        <filePath></filePath>
        <md5></md5>
        <description></description> 
        <launchArgs></launchArgs> 
    </add>
    
    <remove>
        <filePath></filePath>
        <description></description> 
        <launchArgs></launchArgs> 
    </remove>
</sharpUpdate>
```

# Acknowledgments
SharpUpdate is modified from AutoUpdater by BetterCoder on Youtube. His tutorial can be found here: http://goo.gl/n7btY
