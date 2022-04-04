x = int(input())
y = int(input())

quadrant = [1, 2, 3, 4]

if x > 0 and y > 0:
    print(quadrant[0])
elif x > 0 and y < 0:
    print(quadrant[3])
elif x < 0 and y < 0:
    print(quadrant[2])
elif x < 0 and y > 0:
    print(quadrant[1])