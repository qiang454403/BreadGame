# coding=utf-8
import os
import os.path
import fileinput
import shutil
import json
import hashlib

listID = [x for x in range(19) if x>0 ]
listName =[" ","local","mi","al","oppo","qihoo360","vivo","am","iosroot","lenovo","huawei",
			"coolpad","gulu","am","mz","baidu","fb","tx","guluios"]
#= raw_input();


for index in range(len(listName)):
	if index>0:
		nu = str(index)
		print nu+"="+listName[index]
print "请输入对应数字,按回车结束"
number = raw_input("需要更新平台是：")
num = int(number)
if num>0 and num <len(listName):
	print(listName[num])
else:
	print "超过范围"

rootdir = listName[num]+"\patches"
dictfile = {}
print(rootdir)
for parent,dirnames,filenames in os.walk(rootdir):
	#for  dirname in dirnames:
	#	print "parent is :" +parent
	#	print "dirname is :" + dirname
	for filename in filenames:
		#print "parent is :" +parent
		#print "filename is:" + filename
		filepath = parent+"/"+filename
		md5 = hashlib.md5()
		f = open(filepath,'rb')
		fcot = f.read()
		f.close()
		md5.update(fcot)
		my_md5 = md5.hexdigest()
		
		mydict  = {}
		mydict["md5"] = str(my_md5)
		newpath  =filepath.replace("\\",'/')
		pathlens = len(listName[num])+9
		#print(newpath[pathlens:])
		dictfile[newpath[pathlens:]] = mydict
		#fileobject.writelines(os.path.join(parent,filename)+"\r\n")
		#alltexture[filename] = os.path.join(parent,filename)
		#shutil.copy(os.path.join(parent,filename),r"f:\all")
path = listName[num]+"/Manifests/project.manifest"
pathver = listName[num]+"/Manifests/version.manifest"

filen = open(path,"rb+")

alltext = filen.read()
filen.close()
dicts = json.loads(alltext)
dicts["assets"] = dictfile
ver = int(dicts["version"])
ver = ver+1
dicts["version"] = str(ver)

filever = open(pathver,"rb+")
vertext = filever.read()
filever.close()
dictver = json.loads(vertext)
dictver["version"] = str(ver)

with open (pathver,"w") as f:
	json.dump(dictver,f)
#json_str = json.dumps(dicts)
#print json_str
with open (path,"w") as f:
	json.dump(dicts,f)
	

