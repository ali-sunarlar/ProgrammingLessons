Use a git diff command to see what changed:

git diff


Next, commit the change. Instead of using the -a flag, you can explicitly name a file to be staged and committed if Git already has the file in the index (the commit command looks only for the existence of a file).

git commit -m "Add HTML boilerplate to index.html" index.html


Save and close the editor, and then use these commands to commit the changes:

git add -A
git commit -m "Make small wording change; ignore editor backups"