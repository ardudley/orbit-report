export class Satellite {
    name: string;
    orbitType: string;
    type: string;
    operational: boolean;
    launchDate: string;
    shouldShowWarningMethod: boolean;
    
    
    constructor(name: string, type: string, launchDate: string, orbitType: string, operational: boolean) { 
        this.name = name;
        this.type = type;
        this.launchDate = launchDate;
        this.orbitType = orbitType;
        this.operational = operational;
    }

    ngOnInit() { 
       
    }

    shouldShowWarning() {
        if (this.type =='Space Debris') {
            return console.log('Test');
        } else {
            return console.log('Test 2');
        }
    }
}
