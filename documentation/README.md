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

Provide detailed instructions on how to install the module, and include screenshots where necessary.

1. Use the Sitecore Installation wizard to install the [package](#link-to-package)
2. ???
3. Profit

## Configuration

How do you configure your module once it is installed? Are there items that need to be updated with settings, or maybe config files need to have keys updated?

Remember you are using Markdown, you can provide code samples too:

```xml
<?xml version="1.0"?>
<!--
  Purpose: Configuration settings for my hackathon module
-->
<configuration xmlns:patch="http://www.sitecore.net/xmlconfig/">
  <sitecore>
    <settings>
      <setting name="MyModule.Setting" value="Hackathon" />
    </settings>
  </sitecore>
</configuration>
```

## Usage

Provide documentation  about your module, how do the users use your module, where are things located, what do icons mean, are there any secret shortcuts etc.

Please include screenshots where necessary. You can add images to the `./images` folder and then link to them from your documentation:

![Hackathon Logo](images/hackathon.png?raw=true "Hackathon Logo")
![Verndale Logo](images/verndale.jpg?raw=true "Verndale Logo")



## Video

Please provide a video highlighing your Hackathon module submission and provide a link to the video. Either a [direct link](https://www.youtube.com/watch?v=EpNhxW4pNKk) to the video, upload it to this documentation folder or maybe upload it to Youtube...

[![Sitecore Hackathon Video Embedding Alt Text](https://img.youtube.com/vi/EpNhxW4pNKk/0.jpg)](https://www.youtube.com/watch?v=EpNhxW4pNKk)
