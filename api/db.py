from cmath import log
import pymysql
from pymysql.cursors import DictCursor
import datetime

def userGetInfo(login:str):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT * FROM authData WHERE login = '{login}'")
        rows = cur.fetchall()
        return rows

def userGetInfo1(login:str):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT idAuth, role FROM authData WHERE login = '{login}'")
        rows = cur.fetchall()
        data = {"authID" : rows[0].get("idAuth"), "authRole" : rows[0].get("role")}
        return data

def userGetProfile(login):
    data = userGetInfo1(login)
    authId = data.get("authID")
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT * FROM profile WHERE idAuth = {authId}")
        rows = cur.fetchall()
        return rows

def userRegistartion(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        login = data.get('login')
        cur = con.cursor()
        cur.execute(f"SELECT * FROM authData WHERE login = '{login}'")
        rows = cur.fetchall()
        con.commit()
    if len(rows) == 0:
        with con:
            con.connect()
            cur = con.cursor()
            sql = "INSERT INTO authData (login, password, role) VALUES ('{0}', '{1}', '{2}')".format(data.get('login'),data.get('password'),data.get('role'))
            cur.execute(sql)
            insertID = con.insert_id()
            con.commit()
        with con: 
            con.connect()
            cur = con.cursor()    
            sql = "INSERT INTO profile (fName, mName, sName, email, phone, lastLogin, idAuth, idPassport, idSnils) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, {7}, {8})".format(data.get('fName'), data.get('mName'), data.get('sName'),data.get('email'), data.get('phone'), "2000-01-01 00:00:00", insertID, "0", "0") 
            cur.execute(sql)
            con.commit()
            return True
    else:
        return False

def passportInfo(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        serial = data.get('serial')
        number = data.get('number')
        cur = con.cursor()
        cur.execute(f"SELECT serial, number FROM passport WHERE serial = {serial} AND number = {number}")
        rows = cur.fetchall()
        con.commit()
    if len(rows) == 0:
        with con:
            con.connect()
            cur = con.cursor()
            sql = "INSERT INTO passport (fName, mName, sName, serial, number, address, unitCode, whoIssued, whenIssued, copyFile) VALUES('{0}', '{1}', '{2}', {3}, {4}, '{5}', '{6}', '{7}', '{8}', '{9}')".format(data.get('fName'), data.get('mName'), data.get('sName'), data.get('serial'), data.get('number'), data.get('address'), data.get('unitCode'), data.get('whoIssued'), data.get('whenIssued'), "")
            
            cur.execute(sql)
            print(sql)
            con.commit()     
            return True
    else:
        return False   

def snilsInfo(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        serial = data.get('serial')
        cur = con.cursor()
        cur.execute(f"SELECT * FROM snils WHERE serial = '{serial}'")
        rows = cur.fetchall()
        con.commit()
    if len(rows) == 0:
        with con:
            con.connect()
            cur = con.cursor()
            sql = "INSERT INTO snils (fName, mName, sName, serial, birthday, placeBirth, registrateDate, sex) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')".format(data.get('fName'), data.get('mName'), data.get('sName'), data.get('serial'), data.get('birthday'), data.get('placeBirth'), data.get('registrateDate'), data.get('sex'))
            cur.execute(sql)
            con.commit()
            return True
    else:
            return False

def snilsGetInfo(idSnils:str):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT * FROM snils WHERE idSnils = {idSnils}")
        rows = cur.fetchall()
        return rows   

def pasportGetInfo(idPasport:str):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT * FROM passport WHERE idPasport = {idPasport}")
        rows = cur.fetchall()
        return rows           

def updatePasportInProfile(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        sql = "UPDATE profile SET idPassport = {0} WHERE idProfile = {1}".format(data.get('idPasport'), data.get('idProfile'))
        cur.execute(sql)
        con.commit()

def updateSnilsInProfile(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        sql = "UPDATE profile SET idSnils = {0} WHERE idProfile = {1}".format(data.get('idSnils'), data.get('idProfile'))
        cur.execute(sql)
        con.commit()     

def achievementRegistartion(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        datetime.datetime.now()
        sql = "INSERT INTO achievement (idProfession, idClass, idGroups, idDiscipline, idTeacher, mark, semester, datetime) VALUES({0}, {1}, {2}, {3}, {4}, {5}, {6}, '{7}')".format(data.get('idProfession'), data.get('idClass'), data.get('idGroups'), data.get('idDiscipline'), data.get('idTeacher'), data.get('mark'), data.get('semester'), (datetime.datetime.now()))
        cur.execute(sql)
        con.commit()  
                   
def classInfoRegistration(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        name = data.get('name')
        cur = con.cursor()
        cur.execute(f"SELECT name FROM class WHERE name = '{name}'")
        rows = cur.fetchall()
        con.commit()
    if len(rows) == 0:
        with con:
            con.connect()
            cur = con.cursor()
            sql = "INSERT INTO class (name) VALUES('{0}')".format(data.get('name'))
            cur.execute(sql)
            con.commit()
            return True
    else: 
        return False    

def controlInfoRegistration(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        name = data.get('name')
        cur = con.cursor()
        cur.execute(f"SELECT name FROM control WHERE name = '{name}'")
        rows = cur.fetchall()
        con.commit()
    if len(rows) == 0:
        with con:
            con.connect()
            cur = con.cursor()
            sql = "INSERT INTO control (name) VALUES('{0}')".format(data.get('name'))
            cur.execute(sql)
            con.commit()   
            return True
    else:
        return False

def CourseworkRegistration(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        name = data.get('name')
        cur = con.cursor()
        cur.execute(f"SELECT name FROM coursework WHERE name = '{name}'")
        rows = cur.fetchall()
        con.commit()
    if len(rows) == 0:
        with con:
            con.connect()
            cur = con.cursor()
            sql = "INSERT INTO coursework (name) VALUES('{0}')".format(data.get('name'))
            cur.execute(sql)
            con.commit() 
            return True
    else:
        return False

def disciplineRegistration(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        name = data.get('name')
        cur = con.cursor()
        cur.execute(f"SELECT name FROM discipline WHERE name = '{name}'")
        rows = cur.fetchall()
        con.commit()
    if len(rows) == 0:
        with con:
            con.connect()
            cur = con.cursor()
            sql = "INSERT INTO discipline (name) VALUES('{0}')".format(data.get('name'))
            cur.execute(sql)
            con.commit()    
            return True
    else:
        return False  

def groupRegistration(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        name = data.get('name')
        cur = con.cursor()
        cur.execute(f"SELECT name FROM groups WHERE name = '{name}'")
        rows = cur.fetchall()
        con.commit()
    if len(rows) == 0:
        with con:
            con.connect()
            cur = con.cursor()
            sql = "INSERT INTO groups (name, countStudent, classTeacher) VALUES('{0}', {1}, '{2}')".format(data.get('name'), data.get('countStudent'), data.get('classTeacher'))
            cur.execute(sql)
            con.commit()   
            return True
    else: 
        return False            

def professionRegistration(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        name = data.get('name')
        cur = con.cursor()
        cur.execute(f"SELECT name FROM profession WHERE name = '{name}'")
        rows = cur.fetchall()
        con.commit()
    if len(rows) == 0:
        with con:
            con.connect()
            cur = con.cursor()
            sql = "INSERT INTO profession (name) VALUES('{0}')".format(data.get('name'))
            cur.execute(sql)
            con.commit() 
            return True
    else: 
        return False    

def studentsRegistartion(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        idP = data.get('idProfile')
        cur = con.cursor()
        cur.execute(f"SELECT idProfile FROM students WHERE idProfile = {idP}")
        rows = cur.fetchall()
        con.commit()
    if len(rows) == 0:
        with con:
            con.connect()
            cur = con.cursor()
            sql = "INSERT INTO students (idProfession, idProfile, idAchievement, idGroups, idClass) VALUES({0}, {1}, {2}, {3}, {4})".format(data.get('idProfession'), data.get('idProfile'), data.get('idAchievement'), data.get('idGroups'), data.get('idClass'))
            cur.execute(sql)
            con.commit()  
            return True
    else: 
        return False

def teacherRegistartion(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        idP = data.get('idProfile')
        cur = con.cursor()
        cur.execute(f"SELECT idProfile FROM teacher WHERE idProfile = {idP}")
        rows = cur.fetchall()
        con.commit()
    if len(rows) == 0:
        with con:
            con.connect()
            cur = con.cursor()
            sql = "INSERT INTO teacher (idProfile, idDiscipline, workExpirience, qualification) VALUES({0}, {1}, '{2}', '{3}')".format(data.get('idProfile'), data.get('idDiscipline'), data.get('workExpirience'), data.get('qualification'))
            cur.execute(sql)
            con.commit()   
            return True
    else: 
        return False      

def teacherDisciplineRegistartion(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        sql = "INSERT INTO teacherDiscipline (idTeacher, idDiscipline, idProfession) VALUES({0}, {1}, {2})".format(data.get('idTeacher'), data.get('idDiscipline'), data.get('idProfession'))
        cur.execute(sql)
        con.commit()  

def trainingPlanRegistartion(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        sql = "INSERT INTO trainingPlan (idProfession, idDiscipline, idCoursework, idControl, total, lectures, practice, individualWork, semester) VALUES({0}, {1}, {2}, {3}, '{4}', '{5}', '{6}', '{7}', {8})".format(data.get('idProfession'), data.get('idDiscipline'), data.get('idCoursework'), data.get('idControl'), data.get('total'), data.get('lectures'), data.get('practice'), data.get('individualWork'), data.get('semester'))
        cur.execute(sql)
        con.commit()

def getidAchievement(idA:str):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT * FROM achievement WHERE idAchievement = {idA}")
        rows = cur.fetchall()
        return rows

def getClass(idA:str):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT * FROM class WHERE idClass = {idA}")
        rows = cur.fetchall()
        return rows

def getControl(idA:str):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT * FROM control WHERE idControl = {idA}")
        rows = cur.fetchall()
        return rows

def getCoursework(idA:str):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT * FROM coursework WHERE idCoursework = {idA}")
        rows = cur.fetchall()
        return rows

def getDiscipline(idA:str):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT * FROM discipline WHERE idDiscipline = {idA}")
        rows = cur.fetchall()
        return rows                               

def getGroups(idA:str):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT * FROM groups WHERE idGroups = {idA}")
        rows = cur.fetchall()
        return rows

def getProfession(idA:str):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT * FROM profession WHERE idProfession = {idA}")
        rows = cur.fetchall()
        return rows

def getStudents(idA:str):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT * FROM students WHERE idStudents = {idA}")
        rows = cur.fetchall()
        return rows

def getTeacher(idA:str):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT * FROM teacher WHERE idTeacher = {idA}")
        rows = cur.fetchall()
        return rows

def getTeacherDiscipline(idA:str):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT * FROM teacherDiscipline WHERE idTeacherDiscipline = {idA}")
        rows = cur.fetchall()
        return rows

def getTrainingPlan(idA:str):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        cur = con.cursor()
        cur.execute(f"SELECT * FROM trainingPlan WHERE idTrainingPlan = {idA}")
        rows = cur.fetchall()
        return rows

def auth(data:dict):
    con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
    with con:
        login = data.get('login')
        password = data.get('password')
        cur = con.cursor()
        cur.execute(f"SELECT * FROM authData WHERE login = '{login}' AND password = '{password}'")
        rows = cur.fetchall()
        if len(rows) == 0:
            return False
        else:
            return True

def execute(sql:str):
  con = pymysql.connect(host='185.53.232.9', user='teacherBook', password='ponchickDoma', database='teacherBook',cursorclass=DictCursor)
  con.open
  cur = con.cursor()
  cur.execute(sql)
  con.commit()
  con.close()