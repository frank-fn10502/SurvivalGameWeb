let sortItemList;
let ClassSelector;
let preKey = null, desc = false;

let fakeTitlelist = `前幾天有在其他篇看到某樓板友也有相同問題所以當時有回文交流
就是使用中有機率會黑屏或是直接畫面凍結死當
原本有懷疑自己是機王，但幾天下來看01上有幾篇版友的回覆都有遇過這個問題
昨天另一個現實朋友也購入G14新機，剛剛也因為發生同樣問題詢問我有沒有遇到
他去了皇家也用內建的MYASUS檢測，因為是偶發性皇家也沒檢查出東西，MYASUS檢測大家似乎也都是正常的，目前"我個人"看到有人有同樣問題或是現實朋友也有發生已經有好幾例到底是AMD的鍋還是華碩的問題，N的1650TI跟1660TI都不算新產品了，加上我自己GU501跟502都沒有發生過
，所以沒有把N算在問題內客服也根本不用浪費時間打，100%是叫你還原，還原無效建議你送修，並且絕對沒有其他人有反應同樣問題
，問題是買這台就是為了主辦公副娛樂，螢幕保護貼跟上蓋保護貼也貼了，到底是個案or機王還是調教或韌體
呢，Win10更新到最新，BIOS也更新到最新版了，而朋友那邊第一版BIOS也同樣有這情形
附個照片，這台真的是很棒的一台機器，娛樂跟辦公+外型都能兼顧，但目前帶給我的只有麻煩`;

let fakeCategoryData = [
    {
        categoeyName: "槍枝",
        categoryInfo: [
            {
                categoryTitle: "廠牌",
                categoryItemList: [
                    { Name: 'CYBERGUN' },
                    { Name: 'KJ WOKS' },
                    { Name: 'KSC' },
                    { Name: 'KWA / UMAREX' },
                ]
            },
            {
                categoryTitle: "價錢",
                categoryItemList: [
                    { Name: '200以下' },
                    { Name: '500以下' },
                    { Name: '1000以下' },
                    { Name: '1000 ~ 1500' },
                ]
            },
            {
                categoryTitle: "重量",
                categoryItemList: [
                    { Name: '200g' },
                    { Name: '500g' },
                    { Name: '1500g' },
                    { Name: '3kg' },
                ]
            },
        ]
    },
    {
        categoeyName: "服裝",
        categoryInfo: [
            {
                categoryTitle: "廠牌",
                categoryItemList: [
                    { Name: 'aaa' },
                    { Name: 'bbb' },
                    { Name: 'ccc' },
                    { Name: 'ddd' },
                ]
            },
            {
                categoryTitle: "價錢",
                categoryItemList: [
                    { Name: '10以下' },
                    { Name: '20以下' },
                    { Name: '1500以下' },
                    { Name: '3500' },
                ]
            },
            {
                categoryTitle: "褲子",
                categoryItemList: [
                    { Name: '牛仔褲' },
                    { Name: '長褲' },
                    { Name: '短褲' },
                    { Name: '七分褲' },
                ]
            },
            {
                categoryTitle: "上衣",
                categoryItemList: [
                    { Name: 'T-shirt' },
                    { Name: '大衣' },
                    { Name: '衣服' },
                    { Name: 'xxxx' },
                ]
            },
        ]
    },
]
let fakeProductData = [
    // {
    //     name: '',
    //     price: '',
    //     onsalePrice:'',
    //     img:''
    // },
]

//暫時性的
function readomProduct() {

    for (let i = 0; i < 20; i++) {
        let end = Math.random() * Math.floor(fakeTitlelist.length);
        end = (end <= 40 ? 40 : end);
        let start = end - parseInt(Math.random() * Math.floor(30) + 10 + 1);
        let data =
        {
            name: fakeTitlelist.substring(start, end),
            price: parseInt(Math.random() * Math.floor(100000) + 1),
            onsalePrice: '',
            img: `https://picsum.photos/400/300/?random=${parseInt(Math.random() * Math.floor(15) + 5 + 1)}`
        }
        data.onsalePrice = data.price * 0.8;
        fakeProductData.push(data);
    }
}


function initSortTitle(sortItem) {
    sortItemList.forEach(x => {
        let target = x.querySelector('.icon');
        target.classList.remove('fa-sort-down', 'fa-sort-up');
        if (x != sortItem) {
            target.classList.add('fa-sort');
        }
        else {
            target.classList.remove('fa-sort');
        }
    });
}
function changeCategory(selectIndex)
{
    let datas = fakeCategoryData[selectIndex].categoryInfo;

    let categoryPanel = document.querySelector('#Classification');
    categoryPanel.innerHTML = '';
    categoryPanel.innerHTML = createEntity(datas, ["#CategoryPattern", "#CategoryItem"]).innerHTML;
}
function initPage() {
    ClassSelector = document.querySelector('.ControlPanel .ClassSelector');
    sortItemList = document.querySelectorAll('.DisplayPanel .OrderTypeGroup .OrderType');
    sortItemList.forEach((x, y) => {
        x.setAttribute('data-key', `sort-${y}`);
        x.querySelector('.icon').classList.add('fas', 'fa-sort');
        x.addEventListener('click', (e) => {
            let key = e.currentTarget.getAttribute('data-key');
            if (preKey != key) {
                preKey = key;
                desc = false
            }
            else desc = !desc;
            initSortTitle(x);
            x.querySelector('.icon').classList.add((desc ? 'fa-sort-down' : 'fa-sort-up'));
        });
    });

    ClassSelector.innerHTML = '';
    fakeCategoryData.forEach(x => {
        let option = document.createElement('option');
        option.innerHTML = x.categoeyName;
        ClassSelector.appendChild(option);
        console.log(option);
    });

    ClassSelector.addEventListener('change', (e) => {
        let selectIndex = e.currentTarget.selectedIndex;
        changeCategory(selectIndex);
    });
    changeCategory(0);

    readomProduct();
    let productPanel = document.querySelector('.ProductGroup');
    productPanel.innerHTML = '';
    productPanel.innerHTML = createEntity(fakeProductData, ['#ProductCardPattern']).innerHTML;

    // console.log(fakeProductData);
    console.log("Done");//
}
//window.onload = () => {
//    ClassSelector = document.querySelector('.ControlPanel .ClassSelector');
//    sortItemList = document.querySelectorAll('.DisplayPanel .OrderTypeGroup .OrderType');
//    sortItemList.forEach((x, y) => {
//        x.setAttribute('data-key', `sort-${y}`);
//        x.querySelector('.icon').classList.add('fas', 'fa-sort');
//        x.addEventListener('click', (e) => {
//            let key = e.currentTarget.getAttribute('data-key');
//            if (preKey != key) {
//                preKey = key;
//                desc = false
//            }
//            else desc = !desc;
//            initSortTitle(x);
//            x.querySelector('.icon').classList.add((desc ? 'fa-sort-down' : 'fa-sort-up'));
//        });
//    });

//    ClassSelector.innerHTML = '';
//    fakeCategoryData.forEach(x => {
//        let option = document.createElement('option');
//        option.innerHTML = x.categoeyName;
//        ClassSelector.appendChild(option);
//        console.log(option);
//    });
    
//    ClassSelector.addEventListener('change', (e) => {
//        let selectIndex = e.currentTarget.selectedIndex;
//        changeCategory(selectIndex);
//    });
//    changeCategory(0);

//    readomProduct();
//    let productPanel = document.querySelector('.ProductGroup');
//    productPanel.innerHTML = '';
//    productPanel.innerHTML = createEntity(fakeProductData, ['#ProductCardPattern']).innerHTML;

//    // console.log(fakeProductData);
//    console.log("Done");//
//}