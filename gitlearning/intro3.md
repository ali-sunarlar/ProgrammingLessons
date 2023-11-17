Use a git diff command to see what changed:

git diff


Next, commit the change. Instead of using the -a flag, you can explicitly name a file to be staged and committed if Git already has the file in the index (the commit command looks only for the existence of a file).

git commit -m "Add HTML boilerplate to index.html" index.html


Save and close the editor, and then use these commands to commit the changes:

git add -A
git commit -m "Make small wording change; ignore editor backups"

So, you update index.html with the correct path to the style sheet. At this point, you could just commit the corrected version of index.html, but instead, you prefer to put it in the same commit as the original. The --amend option to git commit lets you change history (and how often does one get the chance to change history?).

git commit --amend --no-edit

If you've accidentally deleted a file, you can recover it by bringing the version from the index back into the working tree by using this command:
git checkout -- <file_name>

You also can delete a file by using git rm. This command deletes the file on your disk, but it also has Git record the file deletion in the index.

So, if you ran this command:

git rm index.html
git checkout -- index.html

You could recover index.html by using these two commands:

git reset HEAD index.html
git checkout -- index.html


git branch 

