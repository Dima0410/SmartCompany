
function GenerateChart1(data1, data2, dates) {

    const ctx = document.getElementById('Chart1');

    new Chart(ctx, {
        type: 'line',
        data: {
            labels: dates,
            datasets: [
                {
                    label: 'Доход',
                    data: data1,
                    fill: false,
                    borderColor: 'green',
                    tension: 0.1
                },
                {
                    label: 'Расход',
                    data: data2,
                    fill: false,
                    borderColor: 'red',
                    tension: 0.1
                }
            ]
        },
        options: {
            scales: {
                y: {
                    suggestedMin: 0
                }
            }
        }
    });

}

function GenerateChart2(data1, data2, dates) {

    const ctx = document.getElementById('Chart2');

    new Chart(ctx, {
        type: 'line',
        data: {
            labels: dates,
            datasets: [
                {
                    label: 'Доход',
                    data: data1,
                    fill: false,
                    borderColor: 'green',
                    tension: 0.1
                },
                {
                    label: 'Расход',
                    data: data2,
                    fill: false,
                    borderColor: 'red',
                    tension: 0.1
                }
            ]
        },
        options: {
            scales: {
                y: {
                    suggestedMin: 0
                }
            }
        }
    });

}

function GenerateChart3(data1, data2, data3) {

    const ctx = document.getElementById('Chart3');

    new Chart(ctx, {
        type: 'pie',
        data: {
            labels: ['Овощи', 'Фрукты', 'Прочее'], 

            datasets: [{
                label: '%',
                data: [data1, data2, data3],                
                backgroundColor: [
                    '#27AE60',
                    'rgb(255, 99, 132)',
                    'rgb(255, 205, 86)'
                ],
                hoverOffset: 4
            }]            
        }
    });
}

function GenerateChart4(data1, data2, data3) {

    const ctx = document.getElementById('Chart4');

    new Chart(ctx, {
        type: 'pie',
        data: {
            labels: ['Овощи', 'Фрукты', 'Прочее'],

            datasets: [{
                label: '%',
                data: [data1, data2, data3],
                backgroundColor: [
                    '#27AE60',
                    'rgb(255, 99, 132)',
                    'rgb(255, 205, 86)'
                ],
                hoverOffset: 4
            }]
        }
    });
}

function GenerateChart5(data1, data2) {

    const ctx = document.getElementById('Chart5');

    new Chart(ctx, {
        type: 'pie',
        data: {
            labels: data1,

            datasets: [{
                label: '%',
                data: data2,
                hoverOffset: 4
            }]
        },
        options: {
            plugins: {
                colors: {
                    forceOverride: true
                }
            }
        }
    });
}