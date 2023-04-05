from base64 import decode
from cgitb import text
from email.policy import default
from urllib import response
from aiohttp import web
import json
import db

async def handle(request):
    response_obj = { 'status' : 'True' }
    return web.Response(text=json.dumps(response_obj))

async def login_info(request):
    try:
        getLogin = request.query['login']
        print("Getted login: ", getLogin)

        data = db.userGetInfo(login=getLogin)[0]
        response_obj = { 'status' : 'True', 'Data' : data }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)

async def user_info(request):
    try:
        getInfo = request.query['login']
        print("Getted login: ", getInfo)

        data = db.userGetProfile(login=getInfo)[0]
        response_obj = { 'status' : 'True', 'data' : data }
        return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)

async def user_Registration(request):
    try:
        getInfo = {'login' : request.query['login'],
           'password' : request.query['password'],
            'role' : request.query['role'],
            'fName' : request.query['fName'],
            'mName' : request.query['mName'],
            'sName' : request.query['sName'],
            'email' : request.query['email'],
            'phone' : request.query['phone'],
                     }
        print("Inputing: ", getInfo)
        
        if db.userRegistartion(getInfo):
            response_obj = { 'status' : 'True', 'Message' : 'The user has been successfully registered'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
        else:
            response_obj = { 'status' : 'False', 'Message' : 'A user with this username is already registered'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=500)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)

async def add_PassportInfo(request):
    try:
        getInfo = {
            'fName' : request.query['fName'],
            'mName' : request.query['mName'],
            'sName' : request.query['sName'],
            'serial' : request.query['serial'],
            'number' : request.query['number'],
            'address' : request.query['address'],
            'unitCode' : request.query['unitCode'],
            'whoIssued' : request.query['whoIssued'],
            'whenIssued' : request.query['whenIssued'],         }
        print("Inputing: ", getInfo)
        
        if db.passportInfo(getInfo):
            response_obj = { 'status' : 'True', 'Message' : 'Passport data entered in the register'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
        else:
            response_obj = { 'status' : 'False', 'Message' : 'The passport you entered has already been entered into the database'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=500)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj), status=500)        


async def add_SnilsInfo(request):
    try:
        getInfo = {
            'fName' : request.query['fName'],
            'mName' : request.query['mName'],
            'sName' : request.query['sName'],
            'serial' : request.query['serial'],
            'birthday' : request.query['birthday'],
            'placeBirth' : request.query['placeBirth'],
            'registrateDate' : request.query['registrateDate'],
            'sex' : request.query['sex'],         }
        print("Inputing: ", getInfo)
        
        if db.snilsInfo(getInfo):
            response_obj = { 'status' : 'True', 'Message' : 'Snils data entered in the register'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
        else:
            response_obj = { 'status' : 'False', 'Message' : 'Snils with this serial number is already in the database'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=500)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500) 

async def snils_info(request):
    try:
        getSnilsId = request.query['id']
        print("Getted Snils ID: ", getSnilsId)

        data = db.snilsGetInfo(idSnils=getSnilsId)[0]
        response_obj = { 'status' : 'True', 'data' : data }
        return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)

async def pasport_info(request):
    try:
        getPasportId = request.query['id']
        print("Getted Pasport ID: ", getPasportId)

        data = db.pasportGetInfo(idPasport=getPasportId)[0]
        response_obj = { 'status' : 'True', 'data' : data }
        return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)        


async def updatePasportProfile(request):
    try:
        getInfo = {
            'idProfile' : request.query['idProfile'],
            'idPasport' : request.query['idPasport']         }
        print("Inputing: ", getInfo)
        
        db.updatePasportInProfile(getInfo)

        response_obj = { 'status' : 'True', 'Message' : 'Data Updated'}
        return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500) 

async def updateSnilsProfile(request):
    try:
        getInfo = {
            'idProfile' : request.query['idProfile'],
            'idSnils' : request.query['idSnils']         }
        print("Inputing: ", getInfo)
        
        db.updateSnilsInProfile(getInfo)

        response_obj = { 'status' : 'True', 'Message' : 'Data Updated'}
        return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500) 

async def add_Achievement(request):
    try:
        getInfo = {
            'idProfession' : request.query['idProfession'],
            'idClass' : request.query['idClass'],
            'idGroups' : request.query['idGroups'],
            'idDiscipline' : request.query['idDiscipline'],
            'idTeacher' : request.query['idTeacher'],
            'mark' : request.query['mark'],
            'semester' : request.query['semester'],         }
        print("Inputing: ", getInfo)
        
        db.achievementRegistartion(getInfo)

        response_obj = { 'status' : 'True', 'Message' : 'Achievement data entered in the register'}
        return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)         


async def add_classInfo(request):
    try:
        getInfo = {'name' : request.query['name'],       }
        print("Inputing: ", getInfo)
        
        if db.classInfoRegistration(getInfo):

            response_obj = { 'status' : 'True', 'Message' : 'The entered data is successuful registered'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
        else: 
            response_obj = { 'status' : 'False', 'Message' : 'This value is already in the database'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=500) 
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)    


async def add_controlInfo(request):
    try:
        getInfo = {'name' : request.query['name'],       }
        print("Inputing: ", getInfo)
        
        if db.controlInfoRegistration(getInfo):

            response_obj = { 'status' : 'True', 'Message' : 'The entered data is successuful registered'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
        else: 
            response_obj = { 'status' : 'False', 'Message' : 'This value is already in the database'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=500) 
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)   


async def add_courseworkInfo(request):
    try:
        getInfo = {'name' : request.query['name'],       }
        print("Inputing: ", getInfo)
        
        if db.CourseworkRegistration(getInfo):

            response_obj = { 'status' : 'True', 'Message' : 'The entered data is successuful registered'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
        else: 
            response_obj = { 'status' : 'False', 'Message' : 'This value is already in the database'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=500) 
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)    

async def add_DisciplineInfo(request):
    try:
        getInfo = {'name' : request.query['name'],       }
        print("Inputing: ", getInfo)
        
        if db.disciplineRegistration(getInfo):

            response_obj = { 'status' : 'True', 'Message' : 'The entered data is successuful registered'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
        else: 
            response_obj = { 'status' : 'False', 'Message' : 'This value is already in the database'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=500) 
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)    


async def add_groupInfo(request):
    try:
        getInfo = {
            'name' : request.query['name'],
            'countStudent' : request.query['countStudent'],
            'classTeacher' : request.query['classTeacher'],        }
        print("Inputing: ", getInfo)
        
        if db.groupRegistration(getInfo):

            response_obj = { 'status' : 'True', 'Message' : 'The entered data is successuful registered'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
        else: 
            response_obj = { 'status' : 'False', 'Message' : 'A group with the same name already exists in the database'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=500)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)

async def add_ProfessionInfo(request):
    try:
        getInfo = {'name' : request.query['name'],       }
        print("Inputing: ", getInfo)
        
        if db.professionRegistration(getInfo):

            response_obj = { 'status' : 'True', 'Message' : 'The entered data is successuful registered'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
        else: 
            response_obj = { 'status' : 'False', 'Message' : 'This value is already in the database'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=500) 
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)    

async def add_Students(request):
    try:
        getInfo = {
            'idProfession' : request.query['idProfession'],
            'idProfile' : request.query['idProfile'],
            'idAchievement' : request.query['idAchievement'],
            'idGroups' : request.query['idGroups'],
            'idClass' : request.query['idClass']        }
        print("Inputing: ", getInfo)
        
        if db.studentsRegistartion(getInfo):

            response_obj = { 'status' : 'True', 'Message' : 'The entered data is successuful registered'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
        else: 
            response_obj = { 'status' : 'False', 'Message' : 'The profile you entered is already linked to another student'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=500)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500) 

async def add_Teacher(request):
    try:
        getInfo = {
            'idProfile' : request.query['idProfile'],
            'idDiscipline' : request.query['idDiscipline'],
            'workExpirience' : request.query['workExpirience'],
            'qualification' : request.query['qualification']       }
        print("Inputing: ", getInfo)
        
        if db.teacherRegistartion(getInfo):

            response_obj = { 'status' : 'True', 'Message' : 'The entered data is successuful registered'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
        else: 
            response_obj = { 'status' : 'False', 'Message' : 'The profile you entered is already linked to another student'}
            return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=500)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500) 

async def add_teacherDiscipline(request):
    try:
        getInfo = {
            'idTeacher' : request.query['idTeacher'],
            'idDiscipline' : request.query['idDiscipline'],
            'idProfession' : request.query['idProfession']       }
        print("Inputing: ", getInfo)
        
        db.teacherDisciplineRegistartion(getInfo)

        response_obj = { 'status' : 'True', 'Message' : 'Teacher data entered in the register'}
        return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)                              

async def add_trainingPlan(request):
    try:
        getInfo = {
            'idProfession' : request.query['idProfession'],
            'idDiscipline' : request.query['idDiscipline'],
            'idCoursework' : request.query['idCoursework'], 
            'idControl' : request.query['idControl'],
            'total' : request.query['total'],
            'lectures' : request.query['lectures'],
            'practice' : request.query['practice'],
            'individualWork' : request.query['individualWork'],
            'semester' : request.query['semester'],     }
        print("Inputing: ", getInfo)
        
        db.trainingPlanRegistartion(getInfo)

        response_obj = { 'status' : 'True','Message' : 'Training plan data entered in the register'}
        return web.Response(text=json.dumps(response_obj, default=str,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)     

async def achievement_info(request):
    try:
        getId = request.query['id']
        print("Getted: ", getId)

        data = db.getidAchievement(idA=getId)[0]
        response_obj = { 'status' : 'True', 'data' : data }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False, default=str), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)

async def class_info(request):
    try:
        getId = request.query['id']
        print("Getted: ", getId)

        data = db.getClass(idA=getId)[0]
        response_obj = { 'status' : 'True', 'data' : data }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500) 

async def control_info(request):
    try:
        getId = request.query['id']
        print("Getted: ", getId)

        data = db.getControl(idA=getId)[0]
        response_obj = { 'status' : 'True', 'data' : data }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)   

async def coursework_info(request):
    try:
        getId = request.query['id']
        print("Getted: ", getId)

        data = db.getCoursework(idA=getId)[0]
        response_obj = { 'status' : 'True', 'data' : data }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500) 

async def discipline_info(request):
    try:
        getId = request.query['id']
        print("Getted: ", getId)

        data = db.getDiscipline(idA=getId)[0]
        response_obj = { 'status' : 'True', 'data' : data }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500) 

async def groups_info(request):
    try:
        getId = request.query['id']
        print("Getted: ", getId)

        data = db.getGroups(idA=getId)[0]
        response_obj = { 'status' : 'True', 'data' : data }
        return web.Response(text = json.dumps(response_obj,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)

async def profession_info(request):
    try:
        getId = request.query['id']
        print("Getted: ", getId)

        data = db.getProfession(idA=getId)[0]
        response_obj = { 'status' : 'True', 'data' : data }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)    

async def students_info(request):
    try:
        getId = request.query['id']
        print("Getted: ", getId)

        data = db.getStudents(idA=getId)[0]
        response_obj = { 'status' : 'True', 'data' : data }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)

async def teacher_info(request):
    try:
        getId = request.query['id']
        print("Getted: ", getId)

        data = db.getTeacher(idA=getId)[0]
        response_obj = { 'status' : 'True', 'data' : data }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500) 

async def teacherDiscipline_info(request):
    try:
        getId = request.query['id']
        print("Getted: ", getId)

        data = db.getTeacherDiscipline(idA=getId)[0]
        response_obj = { 'status' : 'True', 'data' : data }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)

async def trainingPlan_info(request):
    try:
        getId = request.query['id']
        print("Getted: ", getId)

        data = db.getTrainingPlan(idA=getId)[0]
        response_obj = { 'status' : 'True', 'data' : data }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=200)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)

async def auth_info(request):
    try:
        getInfo = {
            'login' : request.query['login'],
            'password' : request.query['password']     }
        print("Inputing: ", getInfo)

        if db.auth(getInfo):
            response_obj = { 'status' : 'True', 'Message' : "Authorization was successful" }
            return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=200)
        else:
            response_obj = { 'status' : 'False', 'Message' : "Incorrect login or password" }
            return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)
    except Exception as e:
        response_obj = { 'status' : 'False', 'Message': str(e) }
        return web.Response(text=json.dumps(response_obj,ensure_ascii=False), status=500)

app = web.Application()
app.router.add_get('/', handle)
app.router.add_get('/login', login_info)
app.router.add_get('/pasport', pasport_info)
app.router.add_get('/user', user_info)
app.router.add_get('/snils', snils_info)
app.router.add_get('/achievement', achievement_info)
app.router.add_get('/control', control_info)
app.router.add_get('/class', class_info)
app.router.add_get('/coursework', coursework_info)
app.router.add_get('/discipline', discipline_info)
app.router.add_get('/groups', groups_info)
app.router.add_get('/profession', profession_info)
app.router.add_get('/students', students_info)
app.router.add_get('/teacher', teacher_info)
app.router.add_get('/teacherDiscipline', teacherDiscipline_info)
app.router.add_get('/trainingPlan', trainingPlan_info)
app.router.add_get('/auth', auth_info)
app.router.add_post('/rUser', user_Registration)    
app.router.add_post('/rPasport', add_PassportInfo)
app.router.add_post('/rSnils', add_SnilsInfo)
app.router.add_post('/rAch', add_Achievement)
app.router.add_post('/rClassInfo', add_classInfo)
app.router.add_post('/rControlInfo', add_controlInfo)
app.router.add_post('/rCourseworkInfo', add_courseworkInfo)
app.router.add_post('/rDispinlineInfo', add_DisciplineInfo)
app.router.add_post('/rGroup', add_groupInfo)
app.router.add_post('/rProfessionInfo', add_ProfessionInfo)
app.router.add_post('/rStudents', add_Students)
app.router.add_post('/rTeacher', add_Teacher)
app.router.add_post('/rTeacherDiscipline', add_teacherDiscipline)
app.router.add_post('/rTrainingPlan', add_trainingPlan)



web.run_app(app)