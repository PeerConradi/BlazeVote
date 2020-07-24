# BlazeVote

Project to create a nearly anonymous voting system. Working With Blazor-Server.

## How does it work

You can create a new VoteGroup. This vote Group will generate an Id and a list of allowed Public Keys. You can give these
public keys to the users you want to be able to work. They will also need the VoteGroupId. 

When generating a new voteGroup you will get a Secret. You should write this down since its the password you will
need to administrate the votes. 

The users can use the public key you gave them to generate a hidden key. This will make their vote more anonym. 
Note that every Public Key can only be used once to generate a hidden key. The user should never give the hidden key
to someone else. The publicKey and hiddenKey are not linked to each other, when the user loses this key you need to give him/her
a new public key and should delete the old one.

