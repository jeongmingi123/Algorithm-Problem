import sys
import os


# import는 숫자로 하면 import 안됨

# print("sys path 경로 : %s", (sys.path))
# sys.path.append(os.path.dirname(os.path.abspath(os.path.dirname(os.path.abspath(os.path.dirname(__file__))))))
# print("sys path 경로 : %s", (sys.path))

def aa():
    xx = 10

    def bb():
        xx = 20
    bb()
    print(xx)


aa()
