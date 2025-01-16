import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditCilindroComponent } from './edit-cilindro.component';

describe('EditCilindroComponent', () => {
  let component: EditCilindroComponent;
  let fixture: ComponentFixture<EditCilindroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditCilindroComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditCilindroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
