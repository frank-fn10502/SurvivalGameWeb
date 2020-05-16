function createEntity(objData ,templateList ,title = '',numberNo = -99)
{
    if(Array.isArray(objData))
    {
        let div = document.createElement('div');
        objData.forEach((x,y) =>{
            div.appendChild(createEntity(x ,templateList ,y));
        });
        return div;
    }
    let templateID = templateList[0];

    let template = document.querySelector(templateID).content.cloneNode(true);
    let wrap = document.createElement('div');
    wrap.appendChild(template);   
    
    var re = /{{\w+}}/gi;
    
    wrap.innerHTML = wrap.innerHTML.replace(re, function (match) {
        let key = match.substring(2).slice(0, -2).toLowerCase();
        let replaceKey = Object.keys(objData).find(x => x.toLowerCase() == key);

        if (replaceKey) {
            let data = objData[replaceKey];
            if (typeof data != 'object') {
                let imgReg = /(https:\/\/|.+)(\/.+)*(.jpg|.png|.+random)/ //
                if(data.toString().match(imgReg))
                {
                    return `<img src="${data}" alt="imgGenByFunc">`;
                }
                else
                {
                    return data;
                }
            }
            else if(Array.isArray(data)){
                let str = '';
                data.forEach((x ,y) =>{
                    str += createEntity(x ,templateList.slice(1) ,Object.values(x)[0] ,y).outerHTML.toString();
                });
                return str;
            }
            //未完成 obj > obj
            // else
            // {
            //     return createEntity(objData ,templateList.splice(0,1));
            // }
        }
        else
        {
            return `{{${key}}}`;
        }
    }).replace(re ,`${title}-${numberNo}`);
    return wrap.children[0];
}