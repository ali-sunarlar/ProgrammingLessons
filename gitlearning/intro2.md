Use git add to add the new file to Git's index, followed by git status to check the status. Don't forget the period at the end of the command. It tells Git to index all the files in the current directory that have been added or modified.

git add .

Finally, use git status again to make sure your changes were staged properly:

git status

Use the following command to create a commit:

git commit index.html -m "Create an empty index.html file"

Now, use a git log command to show information about the commit:

git log



