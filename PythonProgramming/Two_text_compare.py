import filecmp
import os

fname1 = 'text1.txt'
fname2 = 'text2.txt'

print(filecmp.cmp(fname1, fname2))


# notice the two backslashes
file1 = "text1.txt"
file2 = "text2.txt"

def compare_files(file1,file2):
    compare = filecmp.cmp(file1,file2)

    if compare == True:
        print("The files are the same.")
    else:
        print("The files are different.")

compare_files(file1,file2)



fname1 = 'text1.txt'
fname2 = 'text2.txt'

f1 = open(fname1)
f2 = open(fname2)

lines1 = f1.readlines()
lines2 = f2.readlines()
i = 0
f1.seek(0)
f2.seek(0)
for line1 in f1:
    if lines1[i] != lines2[i]:
        print(lines1[i])
        print(lines2[i])
        exit(0)
    i = i+1

print("both are equal")










# notice the two backslashes
file1 = "text1.txt"
file2 = "text2.txt"

def compare_files(file1,file2):
    compare = filecmp.cmp(file1,file2)

    if compare == True:
        print("The files are the same.")
    else:
        print("The files are different.")

compare_files(file1,file2)
