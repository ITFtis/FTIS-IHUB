// documents page
const tabBtns = document.querySelectorAll('.tab-btn');
const downloadPage = document.querySelectorAll('.document-download');
const tabContainer = document.querySelector('.docuemnt-tab-container');

// tab
tabContainer.addEventListener('click', function (e) {
    const tabId = e.target.dataset.id;
    console.log(tabId);
    if (tabId) {
        tabBtns.forEach(function (btn) {
            btn.classList.remove('active');
            btn.classList.remove('fw-bold');
            e.target.classList.add('active');
            e.target.classList.add('fw-bold');
        });
        downloadPage.forEach(function (item) {
            item.classList.add('hidden');
        });

        const element = document.getElementById(tabId);
        element.classList.remove('hidden');
        console.log(element);
    }
    console.log(e.target);
});

// hr section
const btnsHr = document.querySelectorAll('.document-line-hr');
const documentContainerHr = document.querySelector('.document-container-hr');
const documentContentHr = document.querySelectorAll('.document-content-hr');

documentContainerHr.addEventListener('click', function (e) {
    const id = e.target.dataset.id;
    console.log(id);
    if (id) {
        btnsHr.forEach(function (btn) {
            btn.classList.remove('active');
            e.target.classList.add('active');
        });
        documentContentHr.forEach(function (item) {
            item.classList.add('hidden');
        });
        const element = document.getElementById(id);
        element.classList.remove('hidden');
    }
});

// finance section
const btnsFinance = document.querySelectorAll('.document-line-finance');
const documentContainerFinance = document.querySelector(
    '.document-container-finance'
);
const documentContentFinance = document.querySelectorAll(
    '.document-content-finance'
);

documentContainerFinance.addEventListener('click', function (e) {
    const id = e.target.dataset.id;
    console.log(id);
    if (id) {
        btnsFinance.forEach(function (btn) {
            btn.classList.remove('active');
            e.target.classList.add('active');
        });
        documentContentFinance.forEach(function (item) {
            item.classList.add('hidden');
        });
        const element = document.getElementById(id);
        element.classList.remove('hidden');
    }
});

// cs section
const btnsCs = document.querySelectorAll('.document-line-cs');
const documentContainerCs = document.querySelector('.document-container-cs');
const documentContentCs = document.querySelectorAll('.document-content-cs');

documentContainerCs.addEventListener('click', function (e) {
    const id = e.target.dataset.id;
    console.log(id);
    if (id) {
        btnsCs.forEach(function (btn) {
            btn.classList.remove('active');
            e.target.classList.add('active');
        });
        documentContentCs.forEach(function (item) {
            item.classList.add('hidden');
        });
        const element = document.getElementById(id);
        element.classList.remove('hidden');
    }
});

// affair section
const btnsAffair = document.querySelectorAll('.document-line-affair');
const documentContainerAffair = document.querySelector(
    '.document-container-affair'
);
const documentContentAffair = document.querySelectorAll(
    '.document-content-affair'
);

documentContainerAffair.addEventListener('click', function (e) {
    const id = e.target.dataset.id;
    console.log(id);
    if (id) {
        btnsAffair.forEach(function (btn) {
            btn.classList.remove('active');
            e.target.classList.add('active');
        });
        documentContentAffair.forEach(function (item) {
            item.classList.add('hidden');
        });
        const element = document.getElementById(id);
        element.classList.remove('hidden');
    }
});

// law section
const btnsLaw = document.querySelectorAll('.document-line-law');
const documentContainerLaw = document.querySelector('.document-container-law');
const documentContentLaw = document.querySelectorAll('.document-content-law');

documentContainerLaw.addEventListener('click', function (e) {
    const id = e.target.dataset.id;
    console.log(id);
    if (id) {
        btnsLaw.forEach(function (btn) {
            btn.classList.remove('active');
            e.target.classList.add('active');
        });
        documentContentLaw.forEach(function (item) {
            item.classList.add('hidden');
        });
        const element = document.getElementById(id);
        element.classList.remove('hidden');
    }
});

// public section
const btnsPublic = document.querySelectorAll('.document-line-public');
const documentContainerPublic = document.querySelector(
    '.document-container-public'
);
const documentContentPublic = document.querySelectorAll(
    '.document-content-public'
);

documentContainerPublic.addEventListener('click', function (e) {
    const id = e.target.dataset.id;
    console.log(id);
    if (id) {
        btnsPublic.forEach(function (btn) {
            btn.classList.remove('active');
            e.target.classList.add('active');
        });
        documentContentPublic.forEach(function (item) {
            item.classList.add('hidden');
        });
        const element = document.getElementById(id);
        element.classList.remove('hidden');
    }
});

// pm section
const btnsPm = document.querySelectorAll('.document-line-pm');
const documentContainerPm = document.querySelector('.document-container-pm');
const documentContentPm = document.querySelectorAll('.document-content-pm');

documentContainerPm.addEventListener('click', function (e) {
    const id = e.target.dataset.id;
    console.log(id);
    if (id) {
        btnsPm.forEach(function (btn) {
            btn.classList.remove('active');
            e.target.classList.add('active');
        });
        documentContentPm.forEach(function (item) {
            item.classList.add('hidden');
        });
        const element = document.getElementById(id);
        element.classList.remove('hidden');
    }
});

// safe section
const btnsSafe = document.querySelectorAll('.document-line-safe');
const documentContainerSafe = document.querySelector(
    '.document-container-safe'
);
const documentContentSafe = document.querySelectorAll('.document-content-safe');

documentContainerSafe.addEventListener('click', function (e) {
    const id = e.target.dataset.id;
    console.log(id);
    if (id) {
        btnsSafe.forEach(function (btn) {
            btn.classList.remove('active');
            e.target.classList.add('active');
        });
        documentContentSafe.forEach(function (item) {
            item.classList.add('hidden');
        });
        const element = document.getElementById(id);
        element.classList.remove('hidden');
    }
});

// faq section
const btnsFaq = document.querySelectorAll('.document-line-faq');
const documentContainerFaq = document.querySelector('.document-container-faq');
const documentContentFaq = document.querySelectorAll('.document-content-faq');

documentContainerFaq.addEventListener('click', function (e) {
    const id = e.target.dataset.id;
    console.log(id);
    if (id) {
        btnsFaq.forEach(function (btn) {
            btn.classList.remove('active');
            e.target.classList.add('active');
        });
        documentContentFaq.forEach(function (item) {
            item.classList.add('hidden');
        });
        const element = document.getElementById(id);
        element.classList.remove('hidden');
    }
});
