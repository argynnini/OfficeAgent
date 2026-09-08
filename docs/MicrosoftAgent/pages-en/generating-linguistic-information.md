---
layout: Conceptual
title: Generating Linguistic Information - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/generating-linguistic-information
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
uhfHeaderId: MSDocsHeader-WinDevCenter
recommendations: true
adobe-target: true
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.author: jken
author: GrantMeStrength
feedback_system: Standard
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_help_link_type: get-help-at-qna
description: Generating Linguistic Information
ms.assetid: 903561f0-89dc-4297-8ea0-3fa150f2e6dd
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 5b65c481-ec7b-8e6b-0dc7-c54308a6ba2e
document_version_independent_id: e1378972-9bcd-d615-f0b1-17492082ed5c
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/generating-linguistic-information.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/generating-linguistic-information.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 989
asset_id: lwef/generating-linguistic-information
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/generating-linguistic-information.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 9350115d-a9e3-e25f-cb03-c34c699fbe8f
---

# Generating Linguistic Information - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

After you have recorded a new sound file, or loaded an existing sound file, you can generate phonetic and word-break information by entering text that corresponds to your sound file in the **Text Representation** box. Then choose the **Generate Linguistic Info** command from the **Edit** menu or from the toolbar. The sound editor displays a progress message and begins processing your sound file. When it finishes generating linguistic information, it displays a mapping of word and phoneme labels for the sound file in boxes in the **Audio Representation** box. Note that the **Generate Linguistic Info** command remains disabled until you enter a text representation for your sound file.

![Screenshot that shows the 'Text Representation' and 'Audio Representation' panes in the Microsoft Linguistic Information Sound Editing Tool.](images/f3listlabel.gif)

If the editor doesn't produce an acceptable set of word or phoneme labels, choose the **Generate Linguistic Info** command again. If the editor does not generate any linguistic information, check your text representation to ensure that all the words are correctly ordered and spelled, and that you don't have any unnecessary spaces around punctuation. Then choose the **Generate Linguistic Info** command again. You can edit the text representation by selecting text in the **Text Representation** text box and using the **Cut**, **Copy**, and **Paste** commands on the **Edit** menu. If you are uncertain of the words the sound file includes, you can play the sound file by choosing **Play** from the **Edit** menu or the editor's toolbar. If the editor still fails to produce linguistic labels, try recording your sound file again. A poor quality recording, especially with excessive background noise, is likely to reduce the probability of generating reasonable linguistic information.

You can also manually create your own linguistic information by selecting part of the audio representation and choosing **Insert Phoneme** or **Insert Word** from the **Edit** menu. These commands are also available if you right-click within the selection.

To see how the linguistic information could be used for lip-syncing character animation with Microsoft Agent, choose the **Play** button on the toolbar and the editor will play your sound file, animating a sample mouth image based on the generated label information.

You can change the phoneme label display to show the IPA (International Phonetic Alphabet) assignments by choosing the **Phoneme Label Display** command on the **Edit** menu, then the IPA command. This displays the byte value for the phoneme. To change back to the descriptive names, choose the **Phoneme Label Display** command again, then choose **Name**.

### Playing a Sound File

You can play standard Windows sound files or linguistically enhanced sound files by choosing the **Play** command from the **Audio** menu or the editor's toolbar. The **Pause** and **Stop** commands enable you to pause or stop playing the sound file. As you play the file, the sample mouth image animates to show how the lip-sync information could be used by a Microsoft Agent character.

You can also play a selected portion of a sound file by dragging a selection in the **Audio Representation** or clicking a word or phoneme label, then choosing **Play**. You can extend an existing selection by pressing SHIFT and clicking, or pressing SHIFT and dragging to the new location in the **Audio Representation**.

### Editing Linguistic Information

You can edit a file's linguistic information in several ways. For example, you can adjust a word or phoneme label's boundary by moving the pointer to the edge of the box that defines the range of the label. When the pointer changes to the boundary move pointer, drag left or right. The editor automatically adjusts the adjacent word or phoneme boundary as well.

![Screenshot that shows edits to a file's linguistic information.](images/f4listadj.gif)

Adjusting a phoneme label's boundary changes the timing of a phoneme when the audio plays. For characters developed for use with Microsoft Agent, changing the phoneme label boundary may change the timing or duration for a mouth image mapped to that phoneme. Changing the boundary of a word label changes the timing of the word's appearance in the character's word balloon.

You can also replace a phoneme assignment by selecting the phoneme label and choosing **Replace Phoneme** from the **Edit** menu, or right-clicking the phoneme label and choosing **Replace Phoneme** from the pop-up menu. The editor displays the **Replace Phoneme** dialog box and highlights the label's current phoneme assignment. You can choose a replacement phoneme by selecting one in the **IPA** list or by choosing another entry in the **Name** list. If more than one IPA translation is available for that name, choose an item in the **IPA** list. To enter an IPA designation for a phoneme that may not be directly included in the language, type in its hex value or multiple hex values, concatenated with a plus (+) character. Once you have selected the replacement phoneme information, choose **OK**, and the editor replaces the phoneme label you selected.

![Screenshot that shows the 'Replace Phoneme' dialog, with '&lt;SIL&gt;' selected as the descriptive label.](images/f5listphone.gif)

Similarly, you can replace a word label by clicking the label's box and choosing **Replace Word**, or by right-clicking the label's box and choosing **Replace Word** from the pop-up menu. The editor displays the **Replace Word** dialog box. Enter the replacement word and choose **OK**.

![Screenshot that shows the 'Replace Word' dialog with 'sound' entered in the 'Word text' text box.](images/f6listrep.gif)

For characters developed for use with Microsoft Agent, replacing a phoneme label may change the mouth image displayed when the sound file plays. Replacing a word replaces the text that appears in the character's word balloon when the [**Speak**](speak-method) method is called.

You can also insert a new phoneme label or word by making a selection in the **Audio Representation** and choosing **Insert Phoneme** or **Insert Word** from the **Edit** menu, or right-clicking within the selection and choosing the commands from the pop-up menu. These commands bring up dialog boxes similar to the **Replace Phoneme** and **Replace Word** dialog boxes, except that the editor inserts the new word or phoneme rather than replacing the existing information.

Finally, you can delete a phoneme or word by selecting its label and choosing **Delete Phoneme** or **Delete Word**. This removes its linguistic information from the file.