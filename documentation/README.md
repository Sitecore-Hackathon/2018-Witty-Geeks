# Documentation


## Summary

**Category:** SXA (Sitecore Experience Accelator)

What is the purpose of your module? What problem does it solve and how does it do that?
The main goal of SXA is to speed up production of websites which means we are looking at multiple authors. 
These authors might be working on same modules/pages/components and will need a way to properly communicate and connect with each other. 
We took inspiration from an existing feature provided by SXA called sticky notes, but, took it further. 
Sticky notes are great perk that SXA offers, but, they are not very apparent - We plan to enhance it to 
-- Narrow the sticky note to be more specific to a user by enabling tagging to a specific user. 
-- Adding a quick notification on content authoring window to provide quick sneak peak at sticky notes added
    -- Still debating if it would be on page level or on content authoring level.
[Sticky Note on SXA](https://doc.sitecore.net/sitecore_experience_accelerator/working_with_content/adding_and_changing_content/add_a_sticky_note "Sticky Note")

How does the end user use the Module?

## Pre-requisites

Does your module rely on other Sitecore modules or frameworks?

- Ensure you have Sitecore 9.1 installed (All pre-requisites needed for 9.1 should be installed as well)
  [Sitecore 9.1](https://doc.sitecore.net/sitecore_experience_accelerator/setting_up_and_configuring "Sitecore 9.1")
- Ensure you have Sitecore Experience Accelerator Version 1.6 installed. Also ensure to install any dependencies for the accelator to be set up
  [Sitecore Experience Accelerator](https://doc.sitecore.net/sitecore_experience_accelerator/setting_up_and_configuring "Set up SXA")
  [Sitecore POwershell Extensions](https://marketplace.sitecore.net/Modules/Sitecore_PowerShell_console.aspx "Set up PowerShell Extensions")

## Installation

Use the steps below to install the module.

1. Ensure above listed pre-requisites are installed.
2. Use the Sitecore Installation wizard to install the [package](https://drive.google.com/open?id=1qUgFmeqrbuCKmoHgTchGwtjWoUS7HTU4 "package")
3. Incase the above link does not work, use the DisplayStickyNotes-1.0.zip present inside the Documentation/ModulePackage folder in this repo.


## Configuration

1. Once the installation of the package is complete, make sure the following files are present in your local sitecore instance.
    \App_Config\Include\WittyGeeks.Hackathon\Foundation\Foundation.SitecoreExtensions.config 
    \bin\WittyGeeks.Hackathon.Foundation.SitecoreExtensions.dll


## Usage

Steps on how to use this module.

1. In Content Editor,go to home item located at "/sitecore/content/Hackathon/Witty Geeks/Home" or create a new page item under "/sitecore/content/Hackathon/Witty Geeks/Home".
2. Open the item in Experience Editor.
3. Drag and Drop a few SXA components on to the page via Toolbox.
4. Use the Toolbox and Add sticky notes a few of these SXA components.
5. Add text to the sticky notes and save your changes.
6. Go to Content Editor and navigate to your page item.
7. You will see a warning message above the quick info section notifying you that sticky notes were added to the SXA components of this item. See screenshot below.

![Content Editor Warning](images/ContentEditorWarning.png?raw=true "Content Editor Warning")

## Video

Please provide a video highlighing your Hackathon module submission and provide a link to the video. Either a [direct link](https://www.youtube.com/watch?v=EpNhxW4pNKk) to the video, upload it to this documentation folder or maybe upload it to Youtube...

[![Sitecore Hackathon Video Embedding Alt Text](https://img.youtube.com/vi/EpNhxW4pNKk/0.jpg)](https://www.youtube.com/watch?v=EpNhxW4pNKk)


![Hackathon Logo](images/hackathon.png?raw=true "Hackathon Logo")
![Verndale Logo](images/verndale.jpg?raw=true "Verndale Logo")
