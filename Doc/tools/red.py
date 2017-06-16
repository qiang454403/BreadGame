from xml.dom.minidom import parse
import xml.dom.minidom
import fileinput

DOMTree = xml.dom.minidom.parse("main.plist")
root = DOMTree.documentElement
if root.hasAttribute("version"):
	print("Verison is : " +root.getAttribute("version"))
dict0 = root.getElementsByTagName('dict')[0]
dict1 = dict0.getElementsByTagName('dict')[0]


dd = dict1.childNodes
#keys = dd[0].getElementsByTagName('key')
fileobject = open("st.txt","w")
cout = 0
for key in dd:
	if (key.nodeName=="key"):
		#print(key.childNodes[0].data)
		lt =key.childNodes[0].data+"\r\n"
		fileobject.writelines(lt)
		cout+=1
print(cout)
#cz = format("changdushi:%d",cout)
fileobject.write(str(cout))
fileobject.close()
		