<?php

use yii\helpers\Html;

/* @var $this yii\web\View */
/* @var $model common\models\Bilet */

$this->title = 'Zmień bilet: ' . ' ' . $model->id;
$this->params['breadcrumbs'][] = ['label' => 'Bilety', 'url' => ['index']];
$this->params['breadcrumbs'][] = ['label' => $model->id, 'url' => ['view', 'id' => $model->id]];
$this->params['breadcrumbs'][] = 'Zmień';
?>
<div class="bilet-update">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
		'loty' => $loty,
		'zakupy' => $zakupy,
    ]) ?>

</div>
