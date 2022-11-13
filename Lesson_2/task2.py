print("Enter text")
print("Select operation")
print("1 Remove all repetitions.")
enter_text = input()

operation =input("Select operation")

if operation == "1" :
    print
    li = []
    for i in enter_text:
        if i not in li:
            li.append(i)
else:
    print("")