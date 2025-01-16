import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TablesCilindrosComponent } from './tables-cilindros.component';

describe('TablesCilindrosComponent', () => {
  let component: TablesCilindrosComponent;
  let fixture: ComponentFixture<TablesCilindrosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TablesCilindrosComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TablesCilindrosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
