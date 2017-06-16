import os
import os.path
import fileinput
import shutil
rootdir = "f:\Project\cgame\client\Resouce\st"

alltexture = {}
#fileobject = open("all.txt","wb")
for parent,dirnames,filenames in os.walk(rootdir):
	#for  dirname in dirnames:
	#	print "parent is :" +parent
	#	print "dirname is :" + dirname
	for filename in filenames:
		#print "parent is :" +parent
		#print "filename is:" + filename
		#fileobject.writelines(os.path.join(parent,filename)+"\r\n")
		alltexture[filename] = os.path.join(parent,filename)
		#shutil.copy(os.path.join(parent,filename),r"f:\all")
#fileobject.close()


#os.path.splitext(path)[1] 文件格式
		