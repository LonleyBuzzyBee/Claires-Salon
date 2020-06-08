# _Claire's Salon_

#### _And Mvc application made to help the user choose a stylist, Latest update 05/29/2020_

#### By _**Mai C.**_



## Description

_This website was created to help Claire's cutomers choose a stylist, and view different clients they've styled._

## Database commands

| Input | Output |
|---|---|
|SHOW DATABASE; |Shows databases available|
|CREATE DATABASE first_last;|creates database/schema |
|CREATE TABLE clients (Name VARCHAR (255), HairStyle VARCHAR (255), StyleTouchup VARCHAR (255),CostOfTouchup INT); | Creates a table for clients with properties name, hairstyle,styletouchup,costoftouchup|
|ALTER TABLE clients ADD ClientId INT NOT NULL AUTO_INCREMENT PRIMARY KEY; |Adds ClientId and makes primary key|
|ALTER TABLE Clients ADD StylistId INT NOT NULL;|puts StylistId as also a property for client|
|CREATE TABLE Stylists (Name VARCHAR (255));|Creates a stylist table|
|ALTER TABLE Stylists ADD StylistId INT NOT NULL AUTO_INCREMENT PRIMARY KEY| gives stylist a primary key stylist id|


--  CREATE TABLE Stylists (Name VARCHAR (255));
-- ALTER TABLE clients ADD ClientId INT NOT NULL AUTO_INCREMENT, StylistId INT NOT NULL AUTO_INCREMENT, PRIMARY KEY(`ClientId`)); 
--  ALTER TABLE Stylists ADD StylistId INT NOT NULL AUTO_INCREMENT PRIMARY KEY; 

## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/LonleyBuzzyBee/Claires-Salon.git```
* Open file in your preferred text editor
* On Mac: ```open -a {your text editor} ClairesSalon.Solution```
* On Windows: ```ClairesSalon.Solution```

_To Download Manually:_

* Navigate to https://github.com/LonleyBuzzyBee/Claires-Salon.
* Click green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "ClairesSalon.Solution-master".


## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/LonleyBuzzyBee/Claires-Salon/issues) here on GitHub._

## Technologies Used

_*C#_
_*MVC_
_*Markdown_
_*DotNet_
_*Entity_

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Mai .C_**