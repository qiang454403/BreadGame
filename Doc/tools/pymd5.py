import hashlib

md5 = hashlib.md5()
f = open('announcement_xml2lua.luac','rb')
fcot = f.read()
f.close()
md5.update(fcot)
print md5.hexdigest()
