or now, Alice will have to submit a pull request to ask you to pull their changes into the main code base. Alice can do that by using git request-pull, which might look like this example:

git request-pull -p origin/main .

In Git, you copy a repo by cloning it using the git clone command. You can clone a repo no matter where it's stored, as long as you have a URL or path to point it to.

git clone


there's nothing for Alice to pull because you haven't made any changes since Alice cloned the repo. You can prove that by using the following command, which shows the output Already up-to-date:
git pull

Then, make a pull request back to the original repo:
git request-pull -p origin/main .

git stash saves the state of the working tree and index by making a couple temporary commits. Think of the stash as a way to save your current work while you do something else, without making a "real" commit or affecting your repository history.

git stash

