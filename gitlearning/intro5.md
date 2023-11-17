# Switch back to the main branch
git checkout main

# Merge my-feature branch into main
git merge my-feature

Now, run the following command to create a bare repo in the shared directory:

git init --bare

Set the name of the default branch for the new repo. To accomplish this step, you can change the HEAD branch to point at a different branch; in this case, the main branch:

git symbolic-ref HEAD refs/heads/main

The output says that the main branch is up to date (in other words, main on Alice's computer matches main in the shared repo). So, Alice merges the add-style branch into the main branch by running git merge --ff-only to perform a fast-forward merge. Then, Alice pushes main from their repo to the shared repo.

git merge --ff-only add-style
git push


main brach'de çalışırken commit edilmeden yeni bir branch'e geçmeden once saklamak için kullanılır

git stash

git stash list

git stash apply

git stash clear

git stash pop


commit atıldıktan sonra önceki commit'e geri dönülmesi



commit'e atılmadan geri dönülmesi için

commit restore




