#coding=utf-8
from stations import stations
import sys
import json
reload(sys)
sys.setdefaultencoding('utf-8')
name = "哈哈"


print stations[name]
print json.dumps(name,encoding="UTF-8", ensure_ascii=False)