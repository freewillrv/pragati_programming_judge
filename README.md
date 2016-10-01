# Pragati - I Judge
This project was created when I was in College. This was used to automate the C programming contest. Anyone who needs to use this for their college C programming contest can Use this. Note : This can easily be modified to work for JAVA programs as well ,which we did.

# What is in a name ? (Pragati)
"Pragati" is the name of the Techfest of our Engineering College. ( A Private Engineering College in West Bengal, India) . It means PROGRESS

# How It Works
This is based on IO redirection. Pragati I-Judge has custom test cases in the DB ( MySQL in this scenario ), Also it has correct outputs for these custom test cases. The user submits his executable file. That is run against the test cases. The output produced is then verified against the correct output provided in the DB, based on which the scoring is done.

# Prerequisites
Dot.Net framework, MySQL Server, Any SQL Editor for data entry [ Optional but recomended ]

# Setup
    1. Run the Database file in your local server. Will create default schemas & tables. Also inserts dummy data.

    2. Goto the * Pragati_Judge/bin/Release/*  Folder. This will contain the executable generated. Also a settings file. Named as system. Edit the settings to match the local setup.
